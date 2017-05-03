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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();

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
        {
            Menu manager = new Menu();
            manager.ShowDialog();
        }

        private void btnAssignTables_Click(object sender, EventArgs e)
        {
            FloorPlan manager = new FloorPlan();
            manager.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login manger = new Login();
            manger.ShowDialog();
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            KitchenScreen manager = new KitchenScreen();
            manager.ShowDialog();

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
        }

    }
}
