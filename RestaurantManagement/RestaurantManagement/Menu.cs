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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Item.c++;
            txtOrdersList.Text += "----Order" + Item.c + " ----- \r\n";
             if(chkHamburger.Checked == true)
            {
                //if the hamburger check box is checked add to the txtbox order list.
                txtOrdersList.Text += "Hamburger" + "\r\n";
                //get the total from item class
                Item.runningTotal += Item.Hamburgerprice();
                // get the total for that item
                Item.GetQuantity(1);
            }
            if (chkDoublePatty.Checked == true)
            {
                txtOrdersList.Text += "Double Patty" + "\r\n";
                Item.runningTotal += Item.doublepattyprice();
                Item.GetQuantity(1);
            }
            if (chkTomato.Checked == true)
            {
                txtOrdersList.Text += "Tomato" + "\r\n";
                Item.runningTotal += Item.tomatoprice();
                Item.GetQuantity(1);
            }
            if (chkOnions.Checked == true)
            {
                txtOrdersList.Text += "Onions" + "\r\n";
                Item.runningTotal += Item.onionprice();
                Item.GetQuantity(1);
            }
            if (chkLettuce.Checked == true)
            {
                txtOrdersList.Text += "Lettuce" + "\r\n";
                Item.runningTotal += Item.lettuceprice();
                Item.GetQuantity(1);
            }
            if (chkPickles.Checked == true)
            {
                txtOrdersList.Text += "Pickles" + "\r\n";
                Item.runningTotal += Item.pickleprice();
                Item.GetQuantity(1);
            }
            if (chkHouseSalad.Checked == true)
            {
                txtOrdersList.Text += "House Salad" + "\r\n";
                Item.runningTotal += Item.housesaladprice();
                Item.GetQuantity(1);
            }
            if (chkGardenSalad.Checked == true)
            {
                txtOrdersList.Text += "Garden Salad" + "\r\n";
                Item.runningTotal += Item.gardensaladprice();
                Item.GetQuantity(1);
            }
            if (chkFruitSalad.Checked == true)
            {
                txtOrdersList.Text += "Fruit Salad" + "\r\n";
                Item.runningTotal += Item.fruitsaladprice();
            }
            if (chkPlainSalad.Checked == true)
            {
                txtOrdersList.Text += "Plain Salad" + "\r\n";
                Item.runningTotal += Item.plainsaladprice();
                Item.GetQuantity(1);
            }
            if (chkCoke.Checked == true)
            {
                txtOrdersList.Text += "Coke" + "\r\n";
                Item.runningTotal += Item.cokeprice();
                Item.GetQuantity(1);
            }
            if (chkSprite.Checked == true)
            {
                txtOrdersList.Text += "Sprite" + "\r\n";
                Item.runningTotal += Item.spriteprice();
                Item.GetQuantity(1);
            }
            if (chkRootBeer.Checked == true){
                txtOrdersList.Text += "Root Beer" + "\r\n";
                Item.runningTotal += Item.rootbeerprice();
                Item.GetQuantity(1);
            }
            if (chkTea.Checked == true){
                txtOrdersList.Text += "Tea" + "\r\n";
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
