using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Project
{
    public partial class frmPurchasing : Form
    {
        public frmPurchasing()
        {
            InitializeComponent();
        }

         public DataTable test = new DataTable();
         public DataTable vt = new DataTable();
         public DataTable holder = new DataTable();
         string fName;
         string lName;
         string eMail;
         string creditCard;
         int seats;

         public void accessDatabase(string request)
         {
             string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
             OleDbDataAdapter da = new OleDbDataAdapter(request, constr);
             da.Fill(vt);
             da.Dispose();
         }
         public void accessDatabase(string request, DataTable data)
         {
             string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
             OleDbDataAdapter da = new OleDbDataAdapter(request, constr);
             da.Fill(data);
             da.Dispose();
         }

         void writeDatabase(string write)
         {
             string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
             OleDbDataAdapter da = new OleDbDataAdapter();
             OleDbConnection con = new OleDbConnection(constr);
             con.Open();
             da.InsertCommand = new OleDbCommand(write, con);
             da.InsertCommand.ExecuteNonQuery();
             con.Close();
         }

         public bool digitCheck(string check) //Short function to check every character of a string and make sure it's a number. Used for credit card input.
         {
             foreach (char c in check)
             {
                 if (c < '0' || c > '9')
                     return false;
             }
             return true;
         }
  

        private void frmPurchasing_Load(object sender, EventArgs e) 
        {
            string review = "SELECT FlightID, DepartureBase, DepartureCountry, Destination, DestinationSpace, DepartureDate, ArrivalDate FROM Flights WHERE FlightID=" + Form1.idHolder;
            accessDatabase(review);
            dgvReview.DataSource = vt;
            //The following code is to check the number of tickets available and modify the user's selection. If none are available, it disables certain selections.
            //Since Economy class is selected by default, it calls that event click here, then follows with First Class Event. Since we stop the user from entering this form if
            //there's no available seats, one of those will work.
            rdoEconomy_Click(sender, e);
            rdoFirstClass_Click(sender, e);
            //Code for column header change:
            dgvReview.Columns[0].HeaderText = "Flight Number";
            dgvReview.Columns[1].HeaderText = "Departure Base";
            dgvReview.Columns[2].HeaderText = "Departure Country";
            dgvReview.Columns[3].HeaderText = "Destination Planet";
            dgvReview.Columns[4].HeaderText = "Destination";
            dgvReview.Columns[5].HeaderText = "Departure Date";
            dgvReview.Columns[6].HeaderText = "Arrival Date";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            eMail = txtEmail.Text;
            creditCard = txtCreditCard.Text;
            seats = Convert.ToInt16(cmbSeats.Text);
            holder.Clear();

            //Error checking for empty fields:
            if (fName.Length == 0)
            {
                MessageBox.Show("Error! You must enter your First Name.");
                txtFirstName.Focus();
                return;
            }
            else if (lName.Length == 0)
            {
                MessageBox.Show("Error! You must enter your Last Name.");
                txtLastName.Focus();
                return;
            }
            else if (eMail.Length == 0)
            {
                MessageBox.Show("Error! Please provide a valid email address.");
                txtEmail.Focus();
                return;
            }
            else if (creditCard.Length == 0)
            {
                MessageBox.Show("Error! Please provide your credit card number.");
                txtCreditCard.Focus();
                return;
            }
            //Checking credit card number for any letters or wrong symbols:
            if (digitCheck(creditCard) == false)
            {
                MessageBox.Show("Error! Please enter a valid credit card. (Length does not matter)");
                txtCreditCard.Focus();
                return;

            }

            writeDatabase("INSERT INTO CustomerInfo (CustomerFirstName, CustomerLastName, Email, CreditCard) VALUES ('"+fName+"', '"+lName+"', '"+eMail+"', '"+creditCard+"')");
            //Now getting customer ID to record in Order table:
            //string cuID = "SELECT CustomerID FROM CustomerInfo WHERE CustomerFirstName LIKE '" + fName + "' AND CreditCard LIKE '" + creditCard + "'";
            string cuID = "SELECT MAX(CustomerID) FROM CustomerInfo";
            accessDatabase(cuID, test); //Keeping it in 'test' to add it on next SQL command
            string customerID = test.Rows[0][0].ToString();
            test.Clear();

            if (rdoFirstClass.Checked == true)
            {
                writeDatabase("INSERT INTO Orders (FlightID, CustomerID, CustomerLastName, CustomerFirstName, CreditCard, Email, DepartureBase, DepartureCountry, Destination, DestinationSpace, FirstClassSeats, DepartureDate) VALUES ('" + vt.Rows[0][0] + "', '"+ customerID +  "','" + lName + "', '" + fName + "', '" + creditCard + "', '"+eMail+"', '"+ vt.Rows[0][1].ToString()+"', '"+vt.Rows[0][2].ToString()+"', '" + vt.Rows[0][3].ToString() + "', '" + vt.Rows[0][4].ToString() + "', " + cmbSeats.Text + ", '" + vt.Rows[0][5].ToString() + "')");
                //Now updating first class seats on flight:
                accessDatabase("SELECT FirstClassAvailable, FirstClassSold FROM Flights WHERE FlightID = " + vt.Rows[0][0].ToString(), holder);
                int available = Convert.ToInt32(holder.Rows[0][1].ToString());
                available -= Convert.ToInt32(cmbSeats.Text);
                int sold = Convert.ToInt32(holder.Rows[0][2].ToString());
                sold += Convert.ToInt32(cmbSeats.Text);
                writeDatabase("UPDATE Flights SET FirstClassAvailable = " + available + ", FirstClassSold = " + sold + " WHERE FlightID = " + vt.Rows[0][0]);
                holder.Clear();
            }
            else if (rdoEconomy.Checked == true)
            {
                writeDatabase("INSERT INTO Orders (FlightID, CustomerID, CustomerLastName, CustomerFirstName, CreditCard, Email, DepartureBase, DepartureCountry, Destination, DestinationSpace, CoachSeats, DepartureDate) VALUES (" + vt.Rows[0][0] + ", '" + customerID + "','" + lName + "', '" + fName + "', '" + creditCard + "', '" + eMail + "', '" + vt.Rows[0][1].ToString() + "', '" + vt.Rows[0][2].ToString() +"', '" +vt.Rows[0][3].ToString() + "', '" + vt.Rows[0][4].ToString() + "', " + cmbSeats.Text + ", '" + vt.Rows[0][5].ToString() + "')");
                //Now updating coach seats on flight:
                accessDatabase("SELECT CoachSeatsAvailable, CoachSeatsSold FROM Flights WHERE FlightID = " + vt.Rows[0][0].ToString(), holder);
                int available = Convert.ToInt32(holder.Rows[0][0].ToString());
                available -= Convert.ToInt32(cmbSeats.Text);
                int sold = Convert.ToInt32(holder.Rows[0][2].ToString());
                sold += Convert.ToInt32(cmbSeats.Text);
                writeDatabase("UPDATE Flights SET CoachSeatsAvailable = " + available + ", CoachSeatsSold = " + sold + " WHERE FlightID = " + vt.Rows[0][0]);
                holder.Clear();
            }
            frmPurchaseComplete pcomp = new frmPurchaseComplete();
            pcomp.ShowDialog();
            this.Close();
        }

        void rdoEconomy_Click(object sender, EventArgs e) //Event to check available seats and display on selection, or disable that option if there are 0 seats.
        {
            holder.Clear();
            string seatCheck = "SELECT CoachSeatsAvailable FROM Flights WHERE FlightID = " + vt.Rows[0][0].ToString();
            accessDatabase(seatCheck, holder);
            int seats = Convert.ToInt16(holder.Rows[0][0].ToString());
            //Here I check to make sure the seats to be diplayed are available:
            if (seats >= 6) //Max number of seats to purchase is 6. Any more, they can contact the sales department.
            {
                cmbSeats.Items.Clear();
                for (int i = 1; i <= 6; i++)
                    cmbSeats.Items.Add(i);
                cmbSeats.SelectedIndex = 0;
            }
            else if (seats < 6 && seats > 0) //Here I make the maximum number of seats selectable to be
            {                                //the max available.
                cmbSeats.Items.Clear();
                for (int i = 1; i <= seats; i++)
                    cmbSeats.Items.Add(i);
                cmbSeats.SelectedIndex = 0;
            }
            else if (seats == 0)
            {
                rdoEconomy.Enabled = false;
                rdoFirstClass.Checked = true;
                MessageBox.Show("Sorry, no more economy seats are available.");
            }
            holder.Clear();
        }
        void rdoFirstClass_Click(object sender, EventArgs e) //Same as last even, only applied to First Class seats
        {
            holder.Clear();
            string seatCheck = "SELECT FirstClassAvailable FROM Flights WHERE FlightID = " + vt.Rows[0][0].ToString();
            accessDatabase(seatCheck, holder);
            int seats = Convert.ToInt16(holder.Rows[0][1].ToString());
            //Here I check to make sure the seats to be diplayed are available:
            if (seats >= 6) //Max number of seats to purchase is 6. Any more, they can contact the sales department.
            {
                cmbSeats.Items.Clear();
                for (int i = 1; i <= 6; i++)
                    cmbSeats.Items.Add(i);
                cmbSeats.SelectedIndex = 0;
            }
            else if (seats < 6 && seats > 0)
            {
                cmbSeats.Items.Clear();
                for (int i = 1; i <= seats; i++)
                    cmbSeats.Items.Add(i);
                cmbSeats.SelectedIndex = 0;
            }
            else if (seats == 0)
            {
                rdoFirstClass.Enabled = false;
                MessageBox.Show("Sorry, no more first class seats are available.");
            }
            holder.Clear();


        }


    }
}
