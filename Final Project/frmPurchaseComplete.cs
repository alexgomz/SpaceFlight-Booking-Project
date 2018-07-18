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
    public partial class frmPurchaseComplete : Form
    {
        public frmPurchaseComplete()
        {
            InitializeComponent();
        }

        public DataTable vt = new DataTable();
        public DataTable holder = new DataTable();
        public DataTable money = new DataTable();

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

        public void pictureSelection() //Long function to display final pictures. Just 2 giant if/else trees, keep this closed.
        {
            if (lblShipName.Text == "U.S.S Aquila")
                picShip.Image = Final_Project.Properties.Resources.Aquila;

            else if (lblShipName.Text == "J.S P80")
                picShip.Image = Final_Project.Properties.Resources.P80;

            else if (lblShipName.Text == "H.M.S Endeavor")
                picShip.Image = Final_Project.Properties.Resources.Endeavor;

            else if (lblShipName.Text == "Kreyser Torgovoye")
                picShip.Image = Final_Project.Properties.Resources.Loren;

            else if (lblShipName.Text == "Atomnaya Bastion")
                picShip.Image = Final_Project.Properties.Resources.Bastion;

            else if (lblShipName.Text == "U.S.S Mirmidon")
                picShip.Image = Final_Project.Properties.Resources.Mirmidon;

            else if (lblShipName.Text == "H.M.C.S Science")
                picShip.Image = Final_Project.Properties.Resources.Endeavor_Science;

            else if (lblShipName.Text == "U.S.S Idris")
                picShip.Image = Final_Project.Properties.Resources.The_Idris;

            else if (lblShipName.Text == "U.S.S Phoenix")
                picShip.Image = Final_Project.Properties.Resources.Phoenix;

            else if (lblShipName.Text == "H.M.S Freelance")
                picShip.Image = Final_Project.Properties.Resources.Freelancer_MAX;

            else if (lblShipName.Text == "U.S.S Starfarer")
                picShip.Image = Final_Project.Properties.Resources.Starfarer;

            else if (lblShipName.Text == "R.F.S Eon")
                picShip.Image = Final_Project.Properties.Resources.Merchantman;

            else if (lblShipName.Text == "U.S.S Genesis")
                picShip.Image = Final_Project.Properties.Resources.Genesis;
            else
                picShip.Image = Final_Project.Properties.Resources.solar_system_flag; //In case it fails, flag.


            //Now for destination pics:
            if (lblDestinationSpace.Text == "New America")
                picDestination.Image = Final_Project.Properties.Resources.mars_colony;

            else if (lblDestinationSpace.Text == "Cao Cao Cloud Resort")
                picDestination.Image = Final_Project.Properties.Resources.venus;

            else if (lblDestinationSpace.Text == "U.S.S Unity")
                picDestination.Image = Final_Project.Properties.Resources.spaceship;

            else if (lblDestinationSpace.Text == "Nova Tokyo")
                picDestination.Image = Final_Project.Properties.Resources.mercury;

            else if (lblDestinationSpace.Text == "Europa Space Station")
                picDestination.Image = Final_Project.Properties.Resources.europa_station;

            else if (lblDestinationSpace.Text == "Callisto Mining Colony")
                picDestination.Image = Final_Project.Properties.Resources.callisto_mining;

            else if (lblDestinationSpace.Text == "Homi J. Bhabha Science Centre")
                picDestination.Image = Final_Project.Properties.Resources.Pluto;

            else if (lblDestinationSpace.Text == "Obama Ring Station")
                picDestination.Image = Final_Project.Properties.Resources.obama_ring_station;

            else if (lblDestinationSpace.Text == "Phobos Space Station")
                picDestination.Image = Final_Project.Properties.Resources.space_station;

            else if (lblDestinationSpace.Text == "Mahatma Gandhi Surface Station")
                picDestination.Image = Final_Project.Properties.Resources.neptune_colony;

            else if (lblDestinationSpace.Text == "Horizon Surface Station")
                picDestination.Image = Final_Project.Properties.Resources.horizon___mars_colony_by_illoo_d8ykxye;

            else if (lblDestinationSpace.Text == "Washington Ridge Colony")
                picDestination.Image = Final_Project.Properties.Resources.lunar_colony;

            else if (lblDestinationSpace.Text == "Novyy Novosibirsk")
                picDestination.Image = Final_Project.Properties.Resources.moon_colony;
            else
                picDestination.Image = Final_Project.Properties.Resources.solar_system_flag; //In case it fails, flag.
        } 

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseComplete_Load(object sender, EventArgs e)
        {
           accessDatabase("SELECT MAX(OrderID) FROM Orders", holder);
           string order = holder.Rows[0][0].ToString();
           holder.Clear();
           string selectAll = "SELECT OrderID, CustomerFirstName, CustomerLastName, Email, DepartureBase, DepartureCountry, Destination, DestinationSpace, FirstClassSeats, CoachSeats, DepartureDate, FlightID FROM Orders WHERE OrderID = " + order;
           accessDatabase(selectAll);
           accessDatabase("SELECT PriceFirstClass, PriceCoach FROM Flights WHERE FlightID = " + vt.Rows[0][11].ToString(), money); //This is to calculate final price.

            //This is long, but I decided for the vertical layout since this is a sort of receipt.
           lsbReceipt.Items.Add("Order ID: " + vt.Rows[0][0].ToString());
           lsbReceipt.Items.Add("First Name: " + vt.Rows[0][1].ToString());
           lsbReceipt.Items.Add("Last Name: " + vt.Rows[0][2].ToString());
           lsbReceipt.Items.Add("Email: " + vt.Rows[0][3].ToString());
           lsbReceipt.Items.Add("Departure: " + vt.Rows[0][4].ToString() + ", " + vt.Rows[0][5].ToString());
           lsbReceipt.Items.Add("Destination: " + vt.Rows[0][7].ToString() + ", " + vt.Rows[0][6].ToString());
           lsbReceipt.Items.Add("First Class Seats: " + vt.Rows[0][8].ToString());
           lsbReceipt.Items.Add("Coach Seats: " + vt.Rows[0][9].ToString());
           lsbReceipt.Items.Add("Departure Date: " + vt.Rows[0][10].ToString());

           if (vt.Rows[0][8].ToString() != "") //If first class tickets were bought...
           {
               string tickets = vt.Rows[0][8].ToString();
               string price = money.Rows[0][0].ToString();
               double totalPrice = Convert.ToDouble(tickets) * Convert.ToDouble(price);
               double taxes = totalPrice * 0.05;
               double finalPrice = totalPrice + taxes;
               lsbReceipt.Items.Add("Tickets Price: $" + Convert.ToString(totalPrice));
               lsbReceipt.Items.Add("Alien Defense Tax: $" + Convert.ToString(taxes));
               lsbReceipt.Items.Add("Final Price: $" + Convert.ToString(finalPrice));
           }
           else if (vt.Rows[0][9].ToString() != "") //If coach tickets were bought...
           {
               string tickets = vt.Rows[0][9].ToString();
               string price = money.Rows[0][1].ToString();
               double totalPrice = Convert.ToDouble(tickets) * Convert.ToDouble(price);
               double taxes = totalPrice * 0.05;
               double finalPrice = totalPrice + taxes;
               lsbReceipt.Items.Add("Tickets Price: $" + Convert.ToString(totalPrice));
               lsbReceipt.Items.Add("Alien Defense Tax: $" + Convert.ToString(taxes));
               lsbReceipt.Items.Add("Final Price: $" + Convert.ToString(finalPrice));
           }

           //Now for the ship and destination pictures:
           string id = vt.Rows[0][11].ToString();
           accessDatabase("SELECT ShipName FROM Flights WHERE FlightID = " + id, holder);
           lblShipName.Text = holder.Rows[0][1].ToString();
           lblDestinationSpace.Text = vt.Rows[0][6].ToString();
           pictureSelection();
        }
    }
}
