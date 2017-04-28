using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Manager : Employee
    {
         
        private string tableStatus;
        private string tableAvailable;
        private int orders;

        public string TableStatus { get; set; }


        public string TableAvailable { get; set; }


        public string Orders { get; set; }

        public void DeleteOrders()
        {

        }

        public void OrderStatus()
        {

        }

        public void ViewOrders()
        {

        }

        public void ChangeTableStatus()
        {

        }
    }
}