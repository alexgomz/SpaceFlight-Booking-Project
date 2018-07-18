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
    public partial class frmTicketInfo : Form
    {
        public frmTicketInfo()
        {
            InitializeComponent();
        }

        public DataTable vt = new DataTable();
        public DataTable holder = new DataTable();

        public void accessDatabase(string request) //For searching
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
            OleDbDataAdapter da = new OleDbDataAdapter(request, constr);
            da.Fill(vt);
            da.Dispose();
        }

        public void accessDatabase(string request, DataTable data) //Overload to store in separate DataTable
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
            OleDbDataAdapter da = new OleDbDataAdapter(request, constr);
            da.Fill(data);
            da.Dispose();
        }

        public void deleteRecord(string delete) //For deleting records
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
            OleDbDataAdapter da = new OleDbDataAdapter(delete, constr);
            OleDbConnection con = new OleDbConnection(constr);
            con.Open();
            OleDbCommand com = new OleDbCommand(delete, con);
            da.DeleteCommand = com;
            da.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        void writeDatabase(string write)    //For updating seats
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbConnection con = new OleDbConnection(constr);
            con.Open();
            da.InsertCommand = new OleDbCommand(write, con);
            da.InsertCommand.ExecuteNonQuery();
            con.Close();
        }

        public void clearGrid()
        {
            vt.Clear();
            dgvSearch.DataSource = null;
            dgvSearch.Rows.Clear();
            dgvSearch.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchPer_Click(object sender, EventArgs e)
        {
            clearGrid();
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string eMail = txtEmail.Text;

            if (fName.Length == 0)
            {
                MessageBox.Show("You must enter your First Name.");
                txtFName.TabIndex = 0;
                return;
            }
            else if (lName.Length == 0)
            {
                MessageBox.Show("You must enter your Last Name.");
                txtLName.TabIndex = 0;
                return;
            }
            else if (eMail.Length == 0)
            {
                MessageBox.Show("You must enter your email.");
                txtEmail.TabIndex = 0;
                return;
            }

            accessDatabase("SELECT OrderID, CustomerFirstName, CustomerLastName, FlightID, Destination, DestinationSpace, FirstClassSeats, CoachSeats, DepartureDate FROM Orders WHERE CustomerFirstName LIKE '" + fName + "' AND CustomerLastName LIKE '" + lName + "' AND  Email LIKE '" + eMail + "'");
            if (vt.Rows.Count == 0)
                MessageBox.Show("Sorry, no matches found.");
            dgvSearch.DataSource = vt;
            dgvSearch.Refresh();
            //Code for column headers:
            dgvSearch.Columns[0].HeaderText = "Order ID";
            dgvSearch.Columns[1].HeaderText = "First Name";
            dgvSearch.Columns[2].HeaderText = "Last Name";
            dgvSearch.Columns[3].HeaderText = "Flight Number";
            dgvSearch.Columns[4].HeaderText = "Destination Planet";
            dgvSearch.Columns[5].HeaderText = "Destination";
            dgvSearch.Columns[6].HeaderText = "First Class Seats";
            dgvSearch.Columns[7].HeaderText = "Coach Seats";
            dgvSearch.Columns[8].HeaderText = "Departure Date";

        }

        private void btnSearchNum_Click(object sender, EventArgs e)
        {
            clearGrid();
            string order = txtOrderNum.Text;

            if (order.Length == 0)
            {
                MessageBox.Show("You must enter you order number.");
                txtOrderNum.Focus();
                return;
            }

            accessDatabase("SELECT OrderID, CustomerFirstName, CustomerLastName, FlightID, Destination, DestinationSpace, FirstClassSeats, CoachSeats, DepartureDate FROM Orders WHERE OrderID = "+order);
            if (vt.Rows.Count == 0)
                MessageBox.Show("Sorry, no matches found.");
            dgvSearch.DataSource = vt;
            dgvSearch.Refresh();
            //Code for column headers:
            dgvSearch.Columns[0].HeaderText = "Order ID";
            dgvSearch.Columns[1].HeaderText = "First Name";
            dgvSearch.Columns[2].HeaderText = "Last Name";
            dgvSearch.Columns[3].HeaderText = "Flight Number";
            dgvSearch.Columns[4].HeaderText = "Destination Planet";
            dgvSearch.Columns[5].HeaderText = "Destination";
            dgvSearch.Columns[6].HeaderText = "First Class Seats";
            dgvSearch.Columns[7].HeaderText = "Coach Seats";
            dgvSearch.Columns[8].HeaderText = "Departure Date";
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (dgvSearch.DataSource == null || dgvSearch.Rows.Count == 0)
            {
                MessageBox.Show("You must select an order");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete your order?", "Confirm", MessageBoxButtons.YesNo); //This displays a confirmation box.
            if (result == DialogResult.Yes)
            {
                string id = vt.Rows[0][0].ToString();
                deleteRecord("DELETE FROM Orders WHERE OrderID = " + id);
                string update = "SELECT FirstClassAvailable, FirstClassSold, CoachSeatsAvailable, CoachSeatsSold FROM Flights WHERE FlightID = " + vt.Rows[0][3].ToString();
                accessDatabase(update, holder);

                if (vt.Rows[0][6].ToString() != "") //For first class tickets
                {
                    int seatsBought = Convert.ToInt32(vt.Rows[0][6].ToString());
                    int seatsAvailable = Convert.ToInt32(holder.Rows[0][0].ToString());
                    int seatsSold = Convert.ToInt32(holder.Rows[0][1].ToString());

                    seatsAvailable += seatsBought;
                    seatsSold -= seatsBought;

                    writeDatabase("UPDATE Flights SET FirstClassAvailable = " + seatsAvailable + ", FirstClassSold = " + seatsSold + " WHERE FlightID = " + vt.Rows[0][3].ToString());
                    holder.Clear();
                    vt.Clear();
                }

                else if (vt.Rows[0][7].ToString() != "") //For coach tickets.
                {
                    int seatsBought = Convert.ToInt32(vt.Rows[0][7].ToString());
                    int seatsAvailable = Convert.ToInt32(holder.Rows[0][2].ToString());
                    int seatsSold = Convert.ToInt32(holder.Rows[0][3].ToString());

                    seatsAvailable += seatsBought;
                    seatsSold -= seatsBought;

                    writeDatabase("UPDATE Flights SET CoachSeatsAvailable = " + seatsAvailable + ", CoachSeatsSold = " + seatsSold + " WHERE FlightID = " + vt.Rows[0][3].ToString());
                    holder.Clear();
                    vt.Clear();
                }
                dgvSearch.DataSource = null;
                dgvSearch.Refresh();
                return;
            }
            else if (result == DialogResult.No)
                return;
            }   
        }
}



