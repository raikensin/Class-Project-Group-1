using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        

        public string EmployeeFirstName { get; set; }
        

        public string EmployeeLastName { get; set; }
       

        public int Hours { get; set; }
       

        public int Wages { get; set; }
       

        public void trackHours()
        {
            throw new System.NotImplementedException();
        }


        public string Position { get; set; }

        
        public Employee(int employID, string empFirstName, string empLastName, int empHour, int empWage, string position)
        {
            EmployeeID = employID;
            EmployeeFirstName = empFirstName;
            EmployeeLastName = empLastName;
            Hours = empHour;
            Wages = empWage;
            Position = position;
        }
       
    }
}