using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class KitchenScreen : Form
    {
        public KitchenScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOrder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();

          
            using (SqlCommand readAllOrderRecords = connection.CreateCommand())
            {
                readAllOrderRecords.CommandText = "select * from dbo.OrderTable where OrderViewed = 0;";

                using (SqlDataReader reader = readAllOrderRecords.ExecuteReader())
                {
                    string rec = "";
                    while (reader.Read())
                    {
                        rec += reader.GetString(1) + " \r\n";
                        //rec += reader.GetString(2);
                        
                        txtOrder1.Text=rec;
                    }
                }
            }
        }

        private void bntComplete_Click(object sender, EventArgs e)
        {
            int OrdN = Int32.Parse(txtOrderNum.Text);

            SqlConnection connection = new SqlConnection();
            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();
            using (SqlCommand updateOrders = connection.CreateCommand())
            {
                updateOrders.CommandText = "update dbo.OrderTable set OrderViewed = 1 where OrderID =" + OrdN + ";";
                var orderupParam = new SqlParameter("OrderViewed", SqlDbType.Int) { Value =1 };
                updateOrders.Parameters.Add(orderupParam);
                updateOrders.ExecuteNonQuery();
            }
            txtOrder1.Text = string.Empty; 
        }

        private void btnCookLogout_Click(object sender, EventArgs e)
        {
            Login newLogOut = new Login();
            newLogOut.ShowDialog();
        }
    }
}
