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
    public partial class Employees : Form
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

        public Employees()
        {
            InitializeComponent();
        }

        public Employees(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
          
        }

        private void txtNewFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
