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
    public partial class frmAdvSearch : Form
    {
        public Form1 LogicalParent { get; set; }
        public frmAdvSearch()
        {
            InitializeComponent();
        }

        DataTable advS = new DataTable();

        public void accessDatabase(string request)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Airline Database.accdb";
            OleDbDataAdapter da = new OleDbDataAdapter(request, constr);
            da.Fill(advS);
            da.Dispose();
        }

        private void frmAdvSearch_Load(object sender, EventArgs e)
        {
            btnCancel.TabIndex = 0;
        }

        //Events for clicking on radio buttons and enabling search functions:
        private void rdoSearchByDestination_Click(object sender, EventArgs e)
        {
            txtSearchByDestination.Enabled = true;
            btnSearchByDestination.Enabled = true;
            //Disable other search fields
            txtSearchByDepartureLocation.Enabled = false;;
            btnSearchByDepartureLocation.Enabled = false;
            rdoSearchByDepartureLocation.Checked = false;
        }
        private void rdoSearchByDepartureLocation_Click(object sender, EventArgs e)
        {
            txtSearchByDepartureLocation.Enabled = true;
            btnSearchByDepartureLocation.Enabled = true;
            //Disable the rest
            txtSearchByDestination.Enabled = false;
            btnSearchByDestination.Enabled = false;
            rdoSearchByDestination.Checked = false;
        }
        //End of events.
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchByDestination_Click(object sender, EventArgs e)
        {
            string sDestination = "SELECT FlightID, DepartureBase, DepartureCountry, Destination, DestinationSpace, DepartureDate, ArrivalDate FROM Flights WHERE Destination LIKE '%" + txtSearchByDestination.Text + "%' OR DestinationSpace LIKE '%" + txtSearchByDestination.Text + "%'";
            accessDatabase(sDestination);
            this.LogicalParent.updateDataGrid(advS);
            if (advS.Rows.Count == 0)
                MessageBox.Show("No matches found");
            this.Close();
        }


        private void btnSearchByDepartureLocation_Click(object sender, EventArgs e)
        {
            string sDeparture = "SELECT FlightID, DepartureBase,DepartureCountry, Destination, DestinationSpace, DepartureDate, ArrivalDate FROM Flights WHERE DepartureBase LIKE '%" + txtSearchByDepartureLocation.Text + "%' OR DepartureCountry LIKE '%" + txtSearchByDepartureLocation.Text + "%'";
            accessDatabase(sDeparture);
            this.LogicalParent.updateDataGrid(advS);
            if (advS.Rows.Count == 0)
                MessageBox.Show("No matches found");
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            string all = "SELECT FlightID, DepartureBase,DepartureCountry, Destination, DestinationSpace, DepartureDate, ArrivalDate FROM Flights";
            accessDatabase(all);
            this.LogicalParent.updateDataGrid(advS);
            this.Close();
        }


    }
}
