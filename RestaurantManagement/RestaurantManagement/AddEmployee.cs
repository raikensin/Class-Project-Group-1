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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }



        private void btnCreate_Click(object sender, EventArgs e)



        {
            string rawFirstName = txtFirstName.Text;
            string rawLastName = txtLastName.Text;
            string rawAddress = txtAddress.Text;
            string rawPhoneNumber = txtPhoneNumber.Text;
            string rawPosition = txtPosition.Text;
            string rawStartDate = txtStartDate.Text;
            double conFirstName;
            double conLastName;
            string userAddress = txtAddress.Text; //This will store the data once it has enter.
            string userPhoneNumber = txtPhoneNumber.Text;
            int conPhoneNumber; //store number as numberic.
            string userFirstName = txtFirstName.Text;
            string userLastName = txtLastName.Text;

            if (!(double.TryParse(rawFirstName, out conFirstName)) && txtFirstName.Text != "")
            {
                if (!double.TryParse(rawLastName, out conLastName) && txtLastName.Text != "")
                {
                    if (txtAddress.Text != "")
                    {
                        if (int.TryParse(userPhoneNumber, out conPhoneNumber) && txtPhoneNumber.Text != "")
                        {
                            if (txtPosition.Text != "")
                            {
                                AddEmployee newEmploy = new AddEmployee();
                                newEmploy.AddEmployee(rawFirstName, rawLastName, rawAddress, rawPhoneNumber, rawPosition, rawStartDate);

                                MessageBox.Show("Adding Employee has been succesful");
                            }
                            else MessageBox.Show("Please enter the correct information");
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Employees newAddEmploy = new Employees();
            newAddEmploy.ShowDialog();





        }

    }
}
