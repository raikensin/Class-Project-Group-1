using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Manager : Employee, IAdmin
    // the manager needs to be able to lo ginto the IAdmin
    // forms straight from the initial log in screen

    // from there the mangager should have the option to pull reports for the last
    // day  week month or year from the data base
    // The manager  could also have the option to add or remove users
    // and change which waiters are assigned to what tables  

   


    {

        private string tableStatus;
        private string tableAvailable;
        private int orders;

        public string TableStatus { get; set; }


        public string TableAvailable { get; set; }


        public string Orders { get; set; }

        public void DeleteOrders()
        {
            if (EmployeeID == 4)
            {
                DeleteOrders();
            }
        }

        public void OrderStatus()
        {

        }

        public void ViewOrders()
        {

        }

        public void ChangeTableStatus()
        {
            if(EmployeeID == 4)
            {
                ChangeTableStatus();
            }
        }
    }
}