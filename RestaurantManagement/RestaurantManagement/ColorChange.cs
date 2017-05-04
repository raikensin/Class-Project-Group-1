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
    public partial class ColorChange : Form 
    {
        public ColorChange()
        {
            InitializeComponent();
        }

        //Can't link the btnTable to the FloorPlan form. Have to somehow link this form to FloorPlan so 
        //I can change the colors of the buttons on that form.

        private void Table1Clean_CheckedChanged(object sender, EventArgs e)
        {
             //btnTable1.BackColor = Color.Green;
        }

        private void Table1Occupied_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable1.BackColor = Color.Yellow;
        }

        private void Table1Dirty_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable1.BackColor = Color.Red;
        }

        private void Table2Clean_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable2.BackColor = Color.Green;
        }

        private void Table2Occupied_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable2.BackColor = Color.Yellow;
        }

        private void Table2Dirty_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable2.BackColor = Color.Red;
        }

        private void Table3Clean_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable3.BackColor = Color.Green;
        }

        private void Table3Occupied_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable3.BackColor = Color.Yellow;
        }

        private void Table3Dirty_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable3.BackColor = Color.Red;
        }

        private void Table4Clean_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable4.BackColor = Color.Green;
        }

        private void Table4Occupied_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable4.BackColor = Color.Yellow;
        }

        private void Table4Dirty_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable4.BackColor = Color.Red;
        }

        private void Table5Clean_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable5.BackColor = Color.Green;
        }

        private void Table5Occupied_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable5.BackColor = Color.Yellow;
        }

        private void Table5Dirty_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable5.BackColor = Color.Red;
        }

        private void Table6clean_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable6.BackColor = Color.Green;
        }

        private void Table6Occupied_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable6.BackColor = Color.Yellow;
        }

        private void Table6Dirty_CheckedChanged(object sender, EventArgs e)
        {
            //btnTable6.BackColor = Color.Red;
        }
    }
}
