﻿using System;
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
    public partial class FloorPlan : Form
    {
        public FloorPlan()
        {
            InitializeComponent();
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {

        }

        private void FloorPlan_Load(object sender, EventArgs e)
        {

        }

        private void btnTableStatus_Click(object sender, EventArgs e)
        {

            //Comment by adrian------ we need to change the table status not just the color; there is a variable that i have to use in my waiter class
            //but right now we have it set up as a boolean. we cant use a boolean becuase that leaves us with only one of two scenarios, we have three 
            //scenarios that can happen. I will change the varialbe when we discuss more about it in class. ----EOTP
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {

        }

        private void btnTable2_Click(object sender, EventArgs e)
        {

        }

        private void btnTable3_Click(object sender, EventArgs e)
        {

        }

        private void btnTable5_Click(object sender, EventArgs e)
        {

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnTable1.BackColor = Color.Yellow;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            btnTable2.BackColor = Color.Green;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            btnTable4.BackColor = Color.Green;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            btnTable4.BackColor = Color.Yellow;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            btnTable5.BackColor = Color.Green;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            btnTable6.BackColor = Color.Yellow;
        }

        private void radTable1Clean_CheckedChanged(object sender, EventArgs e)
        {
            btnTable1.BackColor = Color.Green;
        }

        private void radTable1Dirty_CheckedChanged(object sender, EventArgs e)
        {
            btnTable1.BackColor = Color.Red;
        }

        private void radTable2Occ_CheckedChanged(object sender, EventArgs e)
        {
            btnTable2.BackColor = Color.Yellow;
        }

        private void radTable2Dirty_CheckedChanged(object sender, EventArgs e)
        {
            btnTable2.BackColor = Color.Red;
        }

        private void radTable3Clean_CheckedChanged(object sender, EventArgs e)
        {
            btnTable3.BackColor = Color.Green;
        }

        private void radTable3Occ_CheckedChanged(object sender, EventArgs e)
        {
            btnTable3.BackColor = Color.Yellow;
        }

        private void radTable3Dirty_CheckedChanged(object sender, EventArgs e)
        {
            btnTable3.BackColor = Color.Red;
        }

        private void radTable4Dirty_CheckedChanged(object sender, EventArgs e)
        {
            btnTable4.BackColor = Color.Red;
        }

        private void radTable5Occ_CheckedChanged(object sender, EventArgs e)
        {
            btnTable5.BackColor = Color.Yellow;
        }

        private void radTble5Dirty_CheckedChanged(object sender, EventArgs e)
        {
            btnTable5.BackColor = Color.Red;
        }

        private void radTable6Clean_CheckedChanged(object sender, EventArgs e)
        {
            btnTable6.BackColor = Color.Green;
        }

        private void radTable6Dirty_CheckedChanged(object sender, EventArgs e)
        {
            btnTable6.BackColor = Color.Red;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
