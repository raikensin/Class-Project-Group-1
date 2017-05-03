using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

namespace RestaurantManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn6LoginForm_Click(object sender, EventArgs e)
        {

            txtBoxLogin.Text = txtBoxLogin.Text + "6";
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBackLoginForm_Click(object sender, EventArgs e)
        {

        }

        private void btn2LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "2";

        }

        private void btn1LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "1";
        }

        private void btn3LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "3";
        }

        private void btn4LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "4";
        }

        private void btn5LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "5";
        }

        private void btn7LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "7";
        }

        private void btn8LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "8";
        }

        private void btn9LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "9";
        }

        private void btn0LoginForm_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = txtBoxLogin.Text + "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginLoginForm_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");

            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Manager WHERE ID=" + txtBoxLogin.Text, connection);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0].Field<int>("ID").ToString() == "123456")
            {
                this.Hide();
                new Manage().Show();
            }
            else
                MessageBox.Show("Invalid ID");

        }
    }
}

