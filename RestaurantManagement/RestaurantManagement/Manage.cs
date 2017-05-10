using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees newEmpoyee = new Employees();
            newEmpoyee.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        // if menu button is clicked on manager form it will open the menu
        {
            this.Close();
            Menu newMenu = new Menu();
            newMenu.ShowDialog();
        }

        private void btnAssignTables_Click(object sender, EventArgs e)
        // if floor button is clicked it will open the floor plan
        {
            this.Close();
            FloorPlan newFloorPlan = new FloorPlan();
            newFloorPlan.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // if the logout button is clicked it will open the login screen
            this.Close(); 
            Login newLogOut = new Login();
            newLogOut.ShowDialog();
        }

        private void btnCook_Click(object sender, EventArgs e)
        // if the kitchen screen button is clicked it will open the kitchen screen 
        {
            this.Close();
            KitchenScreen newKitchenScreen = new KitchenScreen();
            newKitchenScreen.ShowDialog();

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        // if the add employee button is clicked it will open the employees form (and ideally add the new employee to the database)
        {
            this.Close();
            Employees showEmployees = new Employees();
            showEmployees.ShowDialog();
        }

        private void btnHostBusBoy_Click(object sender, EventArgs e)
        // if the floor plan is synced it will open the floor plan
        {
            this.Close();
            FloorPlan newFloorPlan = new FloorPlan();
            newFloorPlan.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Report newReport = new Report();
            //newReport.ShowDialog();
        }

        private void btnInventoryReports_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();


            using (SqlCommand readAllInventoryRecords = connection.CreateCommand())
            {
                readAllInventoryRecords.CommandText = "select * from dbo.Inventory where OrderViewed = 0;";

                using (SqlDataReader reader = readAllInventoryRecords.ExecuteReader())
                {
                    string rec = "";
                    while (reader.Read())
                    {
                        rec += reader.GetString(1) + " \r\n";


                        //txtInventory.Text = rec;
                    }
                }
            }
        }
    }
}
