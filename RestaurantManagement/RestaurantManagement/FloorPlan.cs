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
            FloorPlan ColorChange = new FloorPlan();
            ColorChange.ShowDialog();
            //This should open the new form ColorChange in a new window, but i don't know how to test it.
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
    }
}
