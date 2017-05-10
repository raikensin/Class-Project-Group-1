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
using RestaurantManagement.Classes;

namespace RestaurantManagement
{
    public partial class Menu : Form
    {
        public int Num=0;
        public Menu()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

                
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                conn.Open();
            using (SqlCommand readAllRecords = conn.CreateCommand())
            {
                readAllRecords.CommandText = "select OrderID from dbo.OrderTable";

                using (SqlDataReader reader = readAllRecords.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Num = reader.GetInt32(0);
                    }
                }
            }
            //update to the next possible index for OrderID
            Num = Num + 1;
            


            //----------------------
            //Send to the database so cook can recieve it
            SqlConnection connection = new SqlConnection();
            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();

            try
            {
                //-----------insert---------------
                using (SqlCommand insertNewOrder = connection.CreateCommand())
                {
                    insertNewOrder.CommandText = "insert into dbo.OrderTable values (@OrderID,@OrderDesc,@OrderViewed);";
                    var OrderIDParam = new SqlParameter("OrderID", SqlDbType.Int) { Value = Num };
                    var OrderParam = new SqlParameter("OrderDesc", SqlDbType.VarChar) { Value = txtOrdersList.Text };
                    var Orderview = new SqlParameter("OrderViewed", SqlDbType.Int) { Value = 0 };

                    insertNewOrder.Parameters.Add(OrderIDParam);
                    insertNewOrder.Parameters.Add(OrderParam);
                    insertNewOrder.Parameters.Add(Orderview);
                    insertNewOrder.ExecuteNonQuery();
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ordersfield from waiter.orders is blank.");
            }


            //clear checkboxes
            chkHamburger.Checked = false;
            chkDoublePatty.Checked = false;
            chkTomato.Checked = false;
            chkOnions.Checked = false;  
            chkLettuce.Checked= false;
            chkPickles.Checked = false;
            chkHouseSalad.Checked = false;
            chkGardenSalad.Checked = false;
            chkFruitSalad.Checked = false;
            chkPlainSalad.Checked = false;
            chkCoke.Checked = false;
            chkSprite.Checked = false;
            chkRootBeer.Checked = false;
            chkTea.Checked = false;
            chkTable1.Checked = false;
            chktable2.Checked = false;
            chktable3.Checked = false;
            chktable4.Checked = false;
            chktable5.Checked = false;
            chktable6.Checked = false;
            txtOrdersList.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login newLogOut = new Login();
            newLogOut.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string table = "";
            int Quant = 0;
            if (chkTable1.Checked == true)
            {
                //table should be stored from/to the database not stored in string
                //string is for testing purpose.
                table = "Table 1";
                Seating.tableOccupied(1);

            }
            else if (chktable2.Checked == true)
            {
                table = "Table 2";
                Seating.tableOccupied(2);
            }
            else if (chktable3.Checked == true)
            {
                table = "Table 3";
                Seating.tableOccupied(3);
            }
            else if (chktable4.Checked == true)
            {
                table = "Table 4";
                Seating.tableOccupied(4);
            }
            else if (chktable5.Checked == true)
            {
                table = "Table 5";
                Seating.tableOccupied(5);
            }
            else if (chktable6.Checked == true)
            {
                table = "Table 6";
                Seating.tableOccupied(6);
            }
           
            txtOrdersList.Text += "----Order#" + Item.c + " for table: " + table + " ----- \r\n";
            if (chkHamburger.Checked == true)
            {
                //if the hamburger check box is checked add to the txtbox order list.
                txtOrdersList.Text += Item.hamburger + "\r\n";
                //save order to waiter class for DB
                Waiter.orders += Item.hamburger;
                //get the total from item class
                Item.runningTotal += Item.Hamburgerprice();
                // get the total for that item

                


                //grab from the database what the quantity is -1

                SqlConnection connection = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection.Open();

                using (SqlCommand readAllRecords = connection.CreateCommand())
                {

                    readAllRecords.CommandText = "select Quantity from dbo.Inventory where ItemID=1;";

                    using (SqlDataReader reader = readAllRecords.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                }
                //update the table.

                using (SqlCommand updateitem = connection.CreateCommand())
                {
                    updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 1 ;";
                    var orderupParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                    updateitem.Parameters.Add(orderupParam);
                    updateitem.ExecuteNonQuery();



                }
            }
            //DoublePatty
                    if (chkDoublePatty.Checked == true)
                    {
                        txtOrdersList.Text += Item.doublepatty + "\r\n";
                        Waiter.orders = Item.doublepatty;
                        Item.runningTotal += Item.doublepattyprice();




                        //grab from the database what the quantity is -1

                        SqlConnection connection3 = new SqlConnection();
                        //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                        connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                        connection3.Open();

                        using (SqlCommand dp = connection3.CreateCommand())
                        {

                            dp.CommandText = "select Quantity from dbo.Inventory where ItemID=2;";

                            using (SqlDataReader reader = dp.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Quant = reader.GetInt32(0);
                                }
                            }
                            //update the table.

                            using (SqlCommand updateitem = connection3.CreateCommand())
                            {
                                updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 2 ;";
                                var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                                updateitem.Parameters.Add(dpu);
                                updateitem.ExecuteNonQuery();



                            }

                        }
                    }
                        if (chkTomato.Checked == true)
                        {
                            txtOrdersList.Text += Item.tomato + "\r\n";
                            Waiter.orders += Item.tomato;
                            Item.runningTotal += Item.tomatoprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=3;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 3 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }

            }
                        if (chkOnions.Checked == true)
                        {
                            txtOrdersList.Text += Item.onions + "\r\n";
                            Waiter.orders += Item.onions;
                            Item.runningTotal += Item.onionprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=3;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 3 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }

            }
                        if (chkLettuce.Checked == true)
                        {
                            txtOrdersList.Text += Item.letttuce + "\r\n";
                            Waiter.orders += Item.letttuce;
                            Item.runningTotal += Item.lettuceprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=4;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 4 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkPickles.Checked == true)
                        {
                            txtOrdersList.Text += Item.pickle + "\r\n";
                            Waiter.orders += Item.pickle;
                            Item.runningTotal += Item.pickleprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=5;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 5 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkHouseSalad.Checked == true)
                        {
                            txtOrdersList.Text += Item.housesalad + "\r\n";
                            Waiter.orders += Item.housesalad;
                            Item.runningTotal += Item.housesaladprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=6;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 6 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkGardenSalad.Checked == true)
                        {
                            txtOrdersList.Text += Item.gardensalad + "\r\n";
                            Waiter.orders += Item.gardensalad;
                            Item.runningTotal += Item.gardensaladprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=7;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 7 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkFruitSalad.Checked == true)
                        {
                            txtOrdersList.Text += Item.fruitsalad + "\r\n";
                            Waiter.orders += Item.fruitsalad;
                            Item.runningTotal += Item.fruitsaladprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=8;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 8 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkPlainSalad.Checked == true)
                        {
                            txtOrdersList.Text += Item.plainsalad + "\r\n";
                            Waiter.orders += Item.plainsalad;
                            Item.runningTotal += Item.plainsaladprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=9;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 9 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkCoke.Checked == true)
                        {
                            txtOrdersList.Text += Item.coke + "\r\n";
                            Waiter.orders += Item.coke;
                            Item.runningTotal += Item.cokeprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=10;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 10 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkSprite.Checked == true)
                        {
                            txtOrdersList.Text += Item.sprite + "\r\n";
                            Waiter.orders += Item.sprite;
                            Item.runningTotal += Item.spriteprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=11;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 11 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkRootBeer.Checked == true)
                        {
                            txtOrdersList.Text += Item.rootbeer + "\r\n";
                            Waiter.orders += Item.rootbeer;
                            Item.runningTotal += Item.rootbeerprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=12;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 12 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        if (chkTea.Checked == true)
                        {
                            txtOrdersList.Text += Item.tea + "\r\n";
                            Waiter.orders += Item.tea;
                            Item.runningTotal += Item.teaprice();
                SqlConnection connection3 = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection3.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                connection3.Open();

                using (SqlCommand dp = connection3.CreateCommand())
                {

                    dp.CommandText = "select Quantity from dbo.Inventory where ItemID=13;";

                    using (SqlDataReader reader = dp.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quant = reader.GetInt32(0);
                        }
                    }
                    //update the table.

                    using (SqlCommand updateitem = connection3.CreateCommand())
                    {
                        updateitem.CommandText = "update dbo.Inventory set Quantity = Quantity-1 where ItemID = 13 ;";
                        var dpu = new SqlParameter("Quantity", SqlDbType.Int) { Value = (Quant - 1) };
                        updateitem.Parameters.Add(dpu);
                        updateitem.ExecuteNonQuery();



                    }

                }
            }
                        //item.c is the count for the orders
            Item.c++;
            txtTotal.Text = Item.runningTotal.ToString();
                        txtTax.Text = (Item.runningTotal * Item.Tax).ToString();
                        txtSubtotal.Text = (Item.runningTotal + (Item.runningTotal * Item.Tax)).ToString();
                        txtOrdersList.Text += "----------------------" + "\r\n";


                        // One time use to run item inventory to database    
                        //Send to the database so cook can recieve it
                        //SqlConnection connection = new SqlConnection();
                        //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                        //connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
                        //connection.Open();
                        //using (SqlCommand insertNewInventory = connection.CreateCommand())
                        //{
                        //    insertNewInventory.CommandText = "insert into dbo.Inventory values (@ItemID,@ItemName, @Quantity, @Price);";
                        //var hitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 1 };
                        //var hitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Hamburger" };
                        //var hquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var hpriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 15.75 };
                        //insertNewInventory.Parameters.Add(hitemIDParam);
                        //insertNewInventory.Parameters.Add(hitemNameParam);
                        //insertNewInventory.Parameters.Add(hquantityParam);
                        //insertNewInventory.Parameters.Add(hpriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var ditemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Double Patty" };
                        //var ditemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 2 };
                        //var dquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var dpriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 6.99 };
                        //insertNewInventory.Parameters.Add(ditemIDParam);
                        //insertNewInventory.Parameters.Add(ditemNameParam);
                        //insertNewInventory.Parameters.Add(dquantityParam);
                        //insertNewInventory.Parameters.Add(dpriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var titemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 3 };
                        //var titemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Tomato" };
                        //var tquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var tpriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 1.99 };
                        //insertNewInventory.Parameters.Add(titemIDParam);
                        //insertNewInventory.Parameters.Add(titemNameParam);
                        //insertNewInventory.Parameters.Add(tquantityParam);
                        //insertNewInventory.Parameters.Add(tpriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var oitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 4 };
                        //var oitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Onions" };
                        //var oquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var opriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 1.99 };
                        //insertNewInventory.Parameters.Add(oitemIDParam);
                        //insertNewInventory.Parameters.Add(oitemNameParam);
                        //insertNewInventory.Parameters.Add(oquantityParam);
                        //insertNewInventory.Parameters.Add(opriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var litemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 5 };
                        //var litemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Lettuce" };
                        //var lquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var lpriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 1.99 };
                        //insertNewInventory.Parameters.Add(litemIDParam);
                        //insertNewInventory.Parameters.Add(litemNameParam);
                        //insertNewInventory.Parameters.Add(lquantityParam);
                        //insertNewInventory.Parameters.Add(lpriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var pitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 6 };
                        //var pitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Pickle" };
                        //var pquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var ppriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 1.99 };
                        //insertNewInventory.Parameters.Add(pitemIDParam);
                        //insertNewInventory.Parameters.Add(pitemNameParam);
                        //insertNewInventory.Parameters.Add(pquantityParam);
                        //insertNewInventory.Parameters.Add(ppriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var hsitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 7 };
                        //var hsitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "House Salad" };
                        //var hsquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var hspriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 5.99 };
                        //insertNewInventory.Parameters.Add(hsitemIDParam);
                        //insertNewInventory.Parameters.Add(hsitemNameParam);
                        //insertNewInventory.Parameters.Add(hsquantityParam);
                        //insertNewInventory.Parameters.Add(hspriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var gsitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 8 };
                        //var gsitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Garden Salad" };
                        //var gsquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var gspriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 9.99 };
                        //insertNewInventory.Parameters.Add(gsitemIDParam);
                        //insertNewInventory.Parameters.Add(gsitemNameParam);
                        //insertNewInventory.Parameters.Add(gsquantityParam);
                        //insertNewInventory.Parameters.Add(gspriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var fsitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 9 };
                        //var fsitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Fruit Salad" };
                        //var fsquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var fspriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 6.99 };
                        //insertNewInventory.Parameters.Add(fsitemIDParam);
                        //insertNewInventory.Parameters.Add(fsitemNameParam);
                        //insertNewInventory.Parameters.Add(fsquantityParam);
                        //insertNewInventory.Parameters.Add(fspriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var coitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 10 };
                        //var coitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Coke" };
                        //var coquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var copriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 2.99 };
                        //insertNewInventory.Parameters.Add(coitemIDParam);
                        //insertNewInventory.Parameters.Add(coitemNameParam);
                        //insertNewInventory.Parameters.Add(coquantityParam);
                        //insertNewInventory.Parameters.Add(copriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var spitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 11 };
                        //var spitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Sprite" };
                        //var spquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var sppriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 2.99 };
                        //insertNewInventory.Parameters.Add(spitemIDParam);
                        //insertNewInventory.Parameters.Add(spitemNameParam);
                        //insertNewInventory.Parameters.Add(spquantityParam);
                        //insertNewInventory.Parameters.Add(sppriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var rbitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 12 };
                        //var rbitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Root Beer" };
                        //var rbquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var rbpriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 2.99 };
                        //insertNewInventory.Parameters.Add(rbitemIDParam);
                        //insertNewInventory.Parameters.Add(rbitemNameParam);
                        //insertNewInventory.Parameters.Add(rbquantityParam);
                        //insertNewInventory.Parameters.Add(rbpriceParam);
                        //insertNewInventory.ExecuteNonQuery();

                        //var ttitemIDParam = new SqlParameter("ItemID", SqlDbType.Int) { Value = 13 };
                        //var ttitemNameParam = new SqlParameter("ItemName", SqlDbType.VarChar) { Value = "Tea" };
                        //var ttquantityParam = new SqlParameter("Quantity", SqlDbType.Int) { Value = 100 };
                        //var ttpriceParam = new SqlParameter("Price", SqlDbType.Money) { Value = 1.99 };
                        //insertNewInventory.Parameters.Add(ttitemIDParam);
                        //insertNewInventory.Parameters.Add(ttitemNameParam);
                        //insertNewInventory.Parameters.Add(ttquantityParam);
                        //insertNewInventory.Parameters.Add(ttpriceParam);
                        //insertNewInventory.ExecuteNonQuery();
                        //}
                    
                
           
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtOrdersList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
