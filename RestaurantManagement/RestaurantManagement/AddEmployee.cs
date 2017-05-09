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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }



        private void btnCreate_Click(object sender, EventArgs e)



        {
            string rawEmpID = txtEmpID.Text;
            int empID = -1;
            string rawFirstName = txtFirstName.Text;
            string rawLastName = txtLastName.Text;
            string rawAddress = txtAddress.Text;
            string rawPhoneNumber = txtPhoneNumber.Text;
            string rawPosition = cmbPosition.Text;
            string rawStartDate = txtStartDate.Text;
            //double conFirstName;
            //double conLastName;
            string userAddress = txtAddress.Text; //This will store the data once it has enter.
            string userPhoneNumber = txtPhoneNumber.Text;
            //int conPhoneNumber; //store number as numberic.
            string userFirstName = txtFirstName.Text;
            string userLastName = txtLastName.Text;



            //DataValid Checker
            bool dataIsValid = true;
            List<string> errorList = new List<string>();

            //Make sure First Name is not empty
            if (string.IsNullOrEmpty(rawFirstName))
            {
                dataIsValid = false;
                errorList.Add("First Name Can NOT be Empty");
            }
            //Make sure Last Name is not empty
            if (string.IsNullOrEmpty(rawLastName))
            {
                dataIsValid = false;
                errorList.Add("Last Name Can NOT be Empty");
            }

            //Make sure employee ID a positive number and not a letter
            if (string.IsNullOrEmpty(rawEmpID))
            {
                dataIsValid = false;
                errorList.Add("ID Field Can NOT be Empty");
            }
            else if (!int.TryParse(rawEmpID, out empID) || empID < 1)
            {
                dataIsValid = false;
                errorList.Add("Emp ID must be Positive Numbers");
            }

            //Make sure employee ID isn't already taken
            else if (!empIDVerify(empID))
            {
                dataIsValid = false;
                errorList.Add("Employee ID is taken");
            }
            
            //If all data is valid, we going to add to SQL
            if (dataIsValid)
            {
                int roleCode = getRoleCodeFromPositionName(rawPosition);
                SaveNewEmployee(empID, rawFirstName, rawLastName, 0, 0, roleCode);
            }
            else
            {
                string error = null;
                foreach (string err in errorList)
                {
                    error += "\n" + err;

                }
            }

        }

        /// <summary>
        /// Check to see if EmpID is exist within the SQL
        /// </summary>
        /// <param name="empID">The employee ID checker</param>
        /// <returns></returns>
        private bool empIDVerify(int empID)
        {
            bool output = true;

            SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");

            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Employees WHERE EmployeeID=" + empID.ToString(), connection);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                output = false;
                
            }

            return output;
        }

        private int getRoleCodeFromPositionName(string name)
        {
            int output = -1;

            SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");

            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM dbo.Roles WHERE EmpRole = '{name}'", connection);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                output = dt.Rows[0].Field<int>("EmpCode");

            }
            return output;
        }

        private void SaveNewEmployee(int empID, string firstName, string lastName, int hour, double wage, int roleCode)
        {
            SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");

            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText=($"INSERT INTO dbo.employees values({empID}, '{firstName}', '{lastName}', {hour}, {wage}, {roleCode})");
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            //SqlCommand sda = new SqlCommand($"INSERT INTO dbo.employees value({empID}, '{firstName}', '{lastName}', {hour}, {wage}, {roleCode})", connection);






        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            Employees newAddEmploy = new Employees();
            newAddEmploy.ShowDialog();





        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
