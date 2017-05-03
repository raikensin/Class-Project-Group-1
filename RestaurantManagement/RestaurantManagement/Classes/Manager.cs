using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class ManagerForm : Employee, IAdmin
    // When the manager logs in it will bring up the admin page
    // from here the manager will have the option to loin to the other forms

    // from there the mangager should have the option to pull reports for the last
    // day  week month or year from the data base


   
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