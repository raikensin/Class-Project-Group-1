using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Host : Employee
    {

        public Host(int employID, string empFirstName, string empLastName, int empHour, int empWage) : base(employID, empFirstName, empLastName, empHour, empWage, "Host")
        {
        }
        private string tableStatus;

        public string TableStatus { get; set; }
        
        public void ChangeTableStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}