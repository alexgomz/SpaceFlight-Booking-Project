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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public DataTable vt = new DataTable();
        public static string idHolder; //To pass the flight ID to the purchasing Form
        int coachSeats, firstClassSeats;

        //Method to access database:
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

        //Made to update data from other Forms
        public void updateDataGrid(DataTable searchData)
        {
            dgvFlights.DataSource = searchData;
            dgvFlights.Refresh();
            picSelection.Image = Final_Project.Properties.Resources.Flag_of_the_United_Federation_of_Planets;
            lblCCPShow.Visible = false;
            lblCCSAvailShow.Visible = false;
            lblFCPShow.Visible = false;
            lblFCSAvailShow.Visible = false;
            lblTravelTimeShow.Visible = false;
        }

        //Method to clear grid before flights' display:
        public void clearGrid()
        {
            vt.Clear();
            dgvFlights.DataSource = null;
            dgvFlights.Rows.Clear();
            dgvFlights.Refresh();
        }

        //Function to simplify planet selection:
        public void planetSelection(string planet)
        {
            string destination = "SELECT FlightID, DepartureBase, DepartureCountry, Destination, DestinationSpace, DepartureDate, ArrivalDate FROM Flights WHERE DestinationSpace LIKE '%" + planet + "%'";
            accessDatabase(destination);
            dgvFlights.DataSource = vt;
            //Changing column headers:
            dgvFlights.Columns[0].HeaderText = "Flight Number";
            dgvFlights.Columns[1].HeaderText = "Departure Base";
            dgvFlights.Columns[2].HeaderText = "Departure Country";
            dgvFlights.Columns[3].HeaderText = "Destination Planet";
            dgvFlights.Columns[4].HeaderText = "Destination";
            dgvFlights.Columns[5].HeaderText = "Departure Date";
            dgvFlights.Columns[6].HeaderText = "Arrival Date";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExit.TabIndex = 0; //Used so no radio button is selected on start of program.
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            if (rdoJupiter.Checked == true)
            {
                clearGrid();
                planetSelection("Jupiter");
            }
            else if (rdoMars.Checked == true)
            {
                clearGrid();
                planetSelection("Mars");
            }
            else if (rdoMercury.Checked == true)
            {
                clearGrid();
                planetSelection("Mercury");
            }
            else if (rdoMoon.Checked == true)
            {
                clearGrid();
                planetSelection("Moon");
            }
            else if (rdoNeptune.Checked == true)
            {
                clearGrid();
                planetSelection("Neptune");
            }
            else if (rdoPluto.Checked == true)
            {
                clearGrid();
                planetSelection("Pluto");
            }
            else if (rdoVenus.Checked == true)
            {
                clearGrid();
                planetSelection("Venus");
            }
            //Clear advanced ticket info from bottom screen:
            lblCCPShow.Visible = false;
            lblCCSAvailShow.Visible = false;
            lblFCPShow.Visible = false;
            lblFCSAvailShow.Visible = false;
            lblTravelTimeShow.Visible = false;
        }

        //Collection of Click events to change pictures in the destination picture box:
        private void rdoJupiter_Click(object sender, System.EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.JUPITER_PLANET;
            picSelection.Refresh();
        }
        private void rdoMars_Click(object sender, EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.MARS_PLANET;
            picSelection.Refresh();
        }
        private void rdoMercury_Click(object sender, EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.mercury_05;
            picSelection.Refresh();
        }
        private void rdoMoon_Click(object sender, EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.MOON;
            picSelection.Refresh();
        }
        private void rdoNeptune_Click(object sender, EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.NEPTUNE_PLANET;
            picSelection.Refresh();
        }
        private void rdoPluto_Click(object sender, EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.PLUTO_PLANET;
            picSelection.Refresh();
        }
        private void rdoVenus_Click(object sender, EventArgs e)
        {
            picSelection.Image = Final_Project.Properties.Resources.VENUS_PLANET;
            picSelection.Refresh();
        }

        //Timer for system time. Set year to 2316 for ambience:
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = DateTime.Now.ToString("dd-MMM-2316" + System.Environment.NewLine + "hh:mm:ss tt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This event checks the user selection and displays more info on the flight:
        private void dgvFlights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //This here calculates the time difference between departure and arrival to inform user of travel time:
            DateTime departure = new DateTime();
            DateTime arrival = new DateTime();

            departure = Convert.ToDateTime(dgvFlights.SelectedCells[5].Value.ToString());
            arrival = Convert.ToDateTime(dgvFlights.SelectedCells[6].Value.ToString());
            lblTravelTimeShow.Text = Convert.ToString((arrival - departure).Days) + " days";
            lblTravelTimeShow.Visible = true;

            //Now, to getting all the other values:
            idHolder = dgvFlights.SelectedCells[0].Value.ToString();
            string id = dgvFlights.SelectedCells[0].Value.ToString(); //It works! Gets the flight ID to check the database for advanced info
                                                                      //like price and availability
            DataTable holder = new DataTable();
            string display = "SELECT PriceFirstClass, PriceCoach, FirstClassAvailable, CoachSeatsAvailable FROM Flights WHERE FlightID=" + id;
            accessDatabase(display, holder); 
            lblFCPShow.Text = "$" + holder.Rows[0][0].ToString();
            lblFCPShow.Visible = true;
            lblCCPShow.Text = "$" + holder.Rows[0][1].ToString();
            lblCCPShow.Visible = true;
            lblFCSAvailShow.Text = holder.Rows[0][2].ToString() + " seats";
            lblFCSAvailShow.Visible = true;
            lblCCSAvailShow.Text = holder.Rows[0][3].ToString() + " seats";
            lblCCSAvailShow.Visible = true;

            //Storing these for later seat checks before purchasing (See btnPurchase click event)
            coachSeats = Convert.ToInt16(holder.Rows[0][3].ToString());
            firstClassSeats = Convert.ToInt16(holder.Rows[0][2].ToString());

        }

        private void lblAdvSearch_Click(object sender, EventArgs e)
        {
            frmAdvSearch frmAdvS = new frmAdvSearch();
            frmAdvS.LogicalParent = this;
            frmAdvS.ShowDialog();
        }

        private void btnTicketInfo_Click(object sender, EventArgs e)
        {
            frmTicketInfo frmTicket = new frmTicketInfo();
            frmTicket.ShowDialog();
        }

        private void btnSelectFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.DataSource == null || dgvFlights.Rows.Count == 0) //To avoid exception when user clicks button and no selection is made
            {                                                                //or the Data Source is empty.                                            
                MessageBox.Show("Please select a flight first.");
                return;
            }
            else if (coachSeats == 0 && firstClassSeats == 0) //This helps me stop the user from trying to book a sold out flight. No overselling in this airline.
            {
                MessageBox.Show("Sorry, there are no more seats in this flight. Please try another");
                return;
            }
            frmPurchasing frmPurchase = new frmPurchasing();
            frmPurchase.ShowDialog();
        }

     }
}
