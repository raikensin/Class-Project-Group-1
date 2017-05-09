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
            if ((String.Compare(txtBoxLogin.Text, " ") < 0))
            {
                txtBoxLogin.Text = txtBoxLogin.Text.Substring(0, txtBoxLogin.Text.Length - 1 + 1);
            }
            else
            {
                txtBoxLogin.Text = txtBoxLogin.Text.Substring(0, txtBoxLogin.Text.Length - 1);
            }
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
            txtBoxLogin.Text = String.Empty;
        }

        private void btnLoginLoginForm_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");

            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Employees Join dbo.Roles on Roles.EmpCode = Employees.RoleCode WHERE EmployeeID=" + txtBoxLogin.Text, connection);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                

                switch(dt.Rows[0].Field<string>("EmpRole"))
                {
                    case "Manager":
                        this.Hide();
                        new Manage().Show();
                        break;

                    case "Waiter":
                        this.Hide();
                        new Menu().Show();
                        break;

                    case "Host":
                        this.Hide();
                        new FloorPlan().Show();
                        break;

                    case "Cook":
                        this.Hide();
                        new KitchenScreen().Show();
                        break;
                    case "Busboy":
                        this.Hide();
                        new FloorPlan().Show();
                        break;
                            
                }
                                             
            }
            else
            {
                
                MessageBox.Show("ID not found");
            }

            txtBoxLogin.Clear();


            //try
            //{
            //    if (dt.Rows.Count == 1)
            //    {
            //        switch (dt.Rows[0]["Role"] as string)
            //        {
            //            case "Admin":
            //                {
            //                    this.Hide();
            //                    Manage aMenu = new Manage();
            //                    aMenu.Show();
            //                    break;
            //                }
            //            case "Employee":
            //                {
            //                    this.Hide();
            //                    Employees pMenu = new Employees();
            //                    pMenu.Show();
            //                    break;
            //                }

            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //Form.Close();
            //}


        }
    }
}

