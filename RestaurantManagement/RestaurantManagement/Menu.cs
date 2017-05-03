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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            if(chkHamburger.Checked == true)
            {
                //if the hamburger check box is checked add to the txtbox order list.
                txtOrdersList.Text += "Hamburger" + "/n";
                //get the total from item class
            }
            if (chkDoublePatty.Checked == true)
            {
                txtOrdersList.Text += "Double Patty" + "/n";
            }
            if (chkTomato.Checked == true)
            {
                txtOrdersList.Text = "Tomato" + "/n";
            }
            if (chkOnions.Checked == true)
            {
                txtOrdersList.Text += "Onions" + "/n";
            }
            if (chkLettuce.Checked == true)
            {
                txtOrdersList.Text += "Lettuce" + "/n";
            }
            if (chkPickles.Checked == true)
            {
                txtOrdersList.Text += "Pickles" + "/n";
            }
            if (chkHouseSalad.Checked == true)
            {
                txtOrdersList.Text += "House Salad" + "/n";
            }
            if (chkGardenSalad.Checked == true)
            {
                txtOrdersList.Text += "Garden Salad" + "/n";
            }
            if (chkFruitSalad.Checked == true)
            {
                txtOrdersList.Text += "Fruit Salad" + "/n";
            }
            if (chkPlainSalad.Checked == true)
            {
                txtOrdersList.Text += "Plain Salad" + "/n";
            }
            if (chkCoke.Checked == true)
            {
                txtOrdersList.Text += "Coke" + "/n";
            }
            if (chkSprite.Checked == true)
            {
                txtOrdersList.Text += "Sprite" + "/n";
            }
            if (chkRootBeer.Checked == true){
                txtOrdersList.Text += "Root Beer" + "/n";
            }
            if (chkTea.Checked == true){
                txtOrdersList.Text += "Tea" + "/n";
            }
            //

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
