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

        public int EmployeeID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string EmployeeFirstName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string EmployeeLastName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double Hours
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

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