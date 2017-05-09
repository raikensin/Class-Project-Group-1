using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Waiter : Employee
    {

        public Waiter(int employID, string empFirstName, string empLastName, int empHour, int empWage): base(employID, empFirstName, empLastName, empHour, empWage, "Waiter")
        {

        }
        public static string orders="";
        private bool tablesAvailble;

        public string GetOrders()
        {
           return orders+=orders + "\r\n";
        }

        public bool TablesAvailble
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}