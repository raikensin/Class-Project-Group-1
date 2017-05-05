using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Employee
    {
        private int employeeID;
        private string employeeFirstName;
        private string employeeLastName;
        private double hours;
        private double wages;
        private int hostLogin=1;
        private int busboyLogin=2;
        private int cookLogin=3;
        private int managerLogin=4;
        private int waiterLogin=5;
        public int EmployeeID { get; set; }
        

        public string EmployeeFirstName { get; set; }
        

        public string EmployeeLastName { get; set; }
       

        public double Hours { get; set; }
       

        public double Wages
        {
            get
            {
                return wages;
            }

            set
            {
                wages = value;
            }
        }

        public void Login()
        {
            throw new System.NotImplementedException();
        }

        public void LogOff()
        {
            throw new System.NotImplementedException();
        }

        public void trackHours()
        {
            throw new System.NotImplementedException();
        }
    }
}