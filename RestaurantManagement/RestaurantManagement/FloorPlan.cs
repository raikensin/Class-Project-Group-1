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
            //check table 1
            if(radTable1Clean.Checked)
            {
                btnTable1.BackColor = Color.Green;
                Busboy.tableClean(1);
            }
            else if(radTable1Dirty.Checked)
            {
                btnTable1.BackColor = Color.Red;
                Busboy.tableDirty(1);
            }
            else if (radTable1Occ.Checked)
            {
                btnTable1.BackColor = Color.Yellow;
                Busboy.tableOccupied(1);
            }
            //check table 2 
            if (radTable2Clean.Checked)
            {
                btnTable2.BackColor = Color.Green;
                Busboy.tableClean(2);
            }
            else if (radTable2Dirty.Checked)
            {
                btnTable2.BackColor = Color.Red;
                Busboy.tableDirty(2);
            }
            else if (radTable2Occ.Checked)
            {
                btnTable2.BackColor = Color.Yellow;
                Busboy.tableOccupied(2);
            }
            //check table 3
            if (radTable3Clean.Checked)
            {
                btnTable3.BackColor = Color.Green;
                Busboy.tableClean(3);
            }
            else if (radTable3Dirty.Checked)
            {
                btnTable3.BackColor = Color.Red;
                Busboy.tableDirty(3);
            }
            else if (radTable3Occ.Checked)
            {
                btnTable3.BackColor = Color.Yellow;
                Busboy.tableOccupied(3);
            }
            //check table 4
            if (radTable4Clean.Checked)
            {
                btnTable4.BackColor = Color.Green;
                Busboy.tableClean(4);
            }
            else if (radTable4Dirty.Checked)
            {
                btnTable4.BackColor = Color.Red;
                Busboy.tableDirty(4);
            }
            else if (radTable4Occ.Checked)
            {
                btnTable4.BackColor = Color.Yellow;
                Busboy.tableOccupied(4);
            }
            //check table 5
            if (radTable5Clean.Checked)
            {
                btnTable5.BackColor = Color.Green;
                Busboy.tableClean(5);
            }
            else if (radTable5Dirty.Checked)
            {
                btnTable5.BackColor = Color.Red;
                Busboy.tableDirty(5);
            }
            else if (radTable5Occ.Checked)
            {
                btnTable5.BackColor = Color.Yellow;
                Busboy.tableOccupied(5);
            }
            //check table 6
            if (radTable6Clean.Checked)
            {
                btnTable6.BackColor = Color.Green;
                Busboy.tableClean(6);
            }
            else if (radTable6Dirty.Checked)
            {
                btnTable6.BackColor = Color.Red;
                Busboy.tableDirty(6);
            }
            else if (radTable6Occ.Checked)
            {
                btnTable6.BackColor = Color.Yellow;
                Busboy.tableOccupied(6);
            }
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
            Login newLogOut = new Login();
            newLogOut.ShowDialog();

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
