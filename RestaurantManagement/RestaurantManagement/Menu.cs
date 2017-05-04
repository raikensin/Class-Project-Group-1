using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestaurantManagement
{
    public partial class Menu : Form 
    {
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
            //Send to the database so cook can recieve it 

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string table = "";
            if (chkTable1.Checked == true)
            {
                //table should be stored from/to the database not stored in string
                //string is for testing purpose.
                table = "Table 1";
            }
            else if (chktable2.Checked == true)
            {
                table = "Table 2";
            }
            else if (chktable3.Checked == true)
            {
                table = "Table 3";
            }
            else if (chktable4.Checked == true)
            {
                table = "Table 4";
            }
            else if (chktable5.Checked == true)
            {
                table = "Table 5";
            }
            else if (chktable6.Checked == true)
            {
                table = "Table 6";
            }
            Item.c++;
            txtOrdersList.Text += "----Order#" + Item.c + " for table: "+ table +" ----- \r\n";
             if(chkHamburger.Checked == true)
            {
                //if the hamburger check box is checked add to the txtbox order list.
                txtOrdersList.Text += Item.hamburger + "\r\n";
                //save order to waiter class for DB
                Waiter.orders += Item.hamburger;
                //get the total from item class
                Item.runningTotal += Item.Hamburgerprice();
                // get the total for that item
                Item.GetQuantity(1);
            }
            if (chkDoublePatty.Checked == true)
            {
                txtOrdersList.Text +=Item.doublepatty + "\r\n";
                Waiter.orders = Item.doublepatty;
                Item.runningTotal += Item.doublepattyprice();
                Item.GetQuantity(1);
            }
            if (chkTomato.Checked == true)
            {
                txtOrdersList.Text += Item.tomato + "\r\n";
                Waiter.orders += Item.tomato;
                Item.runningTotal += Item.tomatoprice();
                Item.GetQuantity(1);
            }
            if (chkOnions.Checked == true)
            {
                txtOrdersList.Text += Item.onions + "\r\n";
                Waiter.orders += Item.onions;
                Item.runningTotal += Item.onionprice();
                Item.GetQuantity(1);
            }
            if (chkLettuce.Checked == true)
            {
                txtOrdersList.Text += Item.letttuce + "\r\n";
                Waiter.orders += Item.letttuce;
                Item.runningTotal += Item.lettuceprice();
                Item.GetQuantity(1);
            }
            if (chkPickles.Checked == true)
            {
                txtOrdersList.Text += Item.pickle + "\r\n";
                Waiter.orders += Item.pickle;
                Item.runningTotal += Item.pickleprice();
                Item.GetQuantity(1);
            }
            if (chkHouseSalad.Checked == true)
            {
                txtOrdersList.Text += Item.housesalad + "\r\n";
                Waiter.orders += Item.housesalad;
                Item.runningTotal += Item.housesaladprice();
                Item.GetQuantity(1);
            }
            if (chkGardenSalad.Checked == true)
            {
                txtOrdersList.Text += Item.gardensalad + "\r\n";
                Waiter.orders += Item.gardensalad;
                Item.runningTotal += Item.gardensaladprice();
                Item.GetQuantity(1);
            }
            if (chkFruitSalad.Checked == true)
            {
                txtOrdersList.Text += Item.fruitsalad + "\r\n";
                Waiter.orders += Item.fruitsalad;
                Item.runningTotal += Item.fruitsaladprice();
            }
            if (chkPlainSalad.Checked == true)
            {
                txtOrdersList.Text += Item.plainsalad + "\r\n";
                Waiter.orders += Item.plainsalad;
                Item.runningTotal += Item.plainsaladprice();
                Item.GetQuantity(1);
            }
            if (chkCoke.Checked == true)
            {
                txtOrdersList.Text +=Item.coke + "\r\n";
                Waiter.orders += Item.coke;
                Item.runningTotal += Item.cokeprice();
                Item.GetQuantity(1);
            }
            if (chkSprite.Checked == true)
            {
                txtOrdersList.Text += Item.sprite + "\r\n";
                Waiter.orders += Item.sprite;
                Item.runningTotal += Item.spriteprice();
                Item.GetQuantity(1);
            }
            if (chkRootBeer.Checked == true){
                txtOrdersList.Text += Item.rootbeer + "\r\n";
                Waiter.orders += Item.rootbeer;
                Item.runningTotal += Item.rootbeerprice();
                Item.GetQuantity(1);
            }
            if (chkTea.Checked == true){
                txtOrdersList.Text += Item.tea + "\r\n";
                Waiter.orders += Item.tea;
                Item.runningTotal += Item.teaprice();
                Item.GetQuantity(1);
            }
            //
            txtTotal.Text = Item.runningTotal.ToString();
            txtTax.Text=(Item.runningTotal * Item.Tax).ToString();
            txtSubtotal.Text = (Item.runningTotal + (Item.runningTotal * Item.Tax)).ToString();
            txtOrdersList.Text += "----------------------" + "\r\n";
            
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
