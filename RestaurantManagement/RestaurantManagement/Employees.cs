using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Employees : Form
    {
        List<Employee> empList = new List<Employee>();
        int employeeIndex = 0;
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
            this.Hide();
            new AddEmployee().Show();
            
          
        }

        private void txtNewFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEmpLogout_Click(object sender, EventArgs e)
        {
            Login newLogOut = new Login();
            newLogOut.ShowDialog();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");

            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Employees Join dbo.Roles on Roles.EmpCode = Employees.RoleCode ", connection);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    int empId = row.Field<int>("EmployeeID");

                    string empFirstName = row.Field<string>("FirstName");
                    string empLastName = row.Field<string>("LastName");
                    int empHour = row.Field<int>("Hours");
                    int empWage = row.Field<int>("Wage");
                    string empPosition = row.Field<string>("EmpRole");

                    switch (empPosition)
                    {
                        case "Manager":
                            empList.Add(new Manager(empId, empFirstName, empLastName, empHour, empWage));
                            break;

                        case "Waiter":
                            empList.Add(new Waiter(empId, empFirstName, empLastName, empHour, empWage));
                            break;

                        case "Host":
                            empList.Add(new Host(empId, empFirstName, empLastName, empHour, empWage));
                            break;

                        case "Cook":
                            empList.Add(new Cook(empId, empFirstName, empLastName, empHour, empWage));
                            break;
                        case "Busboy":
                            empList.Add(new Busboy(empId, empFirstName, empLastName, empHour, empWage));
                            break;

                    }
                }
            }

            LoadEmployee(employeeIndex);
            btnLastEmployee.Enabled = false;
            if(employeeIndex >= empList.Count - 1)
            {
                btnNextEmployee.Enabled = false;
            }
        }

        private void btnNextEmployee_Click(object sender, EventArgs e)
        {
            if(employeeIndex < empList.Count - 1)
            {
                employeeIndex++;
                LoadEmployee(employeeIndex);
                btnLastEmployee.Enabled = true;
            }
            if (employeeIndex >= empList.Count - 1)
            {
                btnNextEmployee.Enabled = false;
            }
        }

        private void LoadEmployee(int index)
        {
            Employee currentEmployee = empList[index];
            txtEmpID.Text = currentEmployee.EmployeeID.ToString();
            txtNewFirstName.Text = currentEmployee.EmployeeFirstName;
            txtNewLastName.Text = currentEmployee.EmployeeLastName;
            txtHours.Text = currentEmployee.Hours.ToString();
            txtWages.Text = currentEmployee.Wages.ToString();
            cmbPosition.Text = currentEmployee.Position;
        }

        private void btnLastEmployee_Click(object sender, EventArgs e)
        {
            if (employeeIndex > 0)
            {
                employeeIndex--;
                LoadEmployee(employeeIndex);
            }
            if (employeeIndex == 0)
            {
                btnLastEmployee.Enabled = false;
            }
        }
    }
}
