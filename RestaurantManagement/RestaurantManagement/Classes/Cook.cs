using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Cook : Employee
    {
        public Cook(int employID, string empFirstName, string empLastName, int empHour, int empWage) : base(employID, empFirstName, empLastName, empHour, empWage, "Cook")
        {
        }
        //private int orders;

        public string Orders { get; set; }
        

        public void ViewOrders()
        {
            
        }

        public void DeleteOrders()
        {
            
        }

        public void OrderStatus()
        {
            
        }
    }
}