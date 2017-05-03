using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Busboy : Employee
    {
        private string tableStatus;

        public string TableStatus { get; set; }

        public void ChangeTableStatus()
        {
            if (EmployeeID == 2)
            {
                ChangeTableStatus();
            }
        }



    }
}