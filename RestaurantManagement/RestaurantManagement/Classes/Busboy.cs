﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Busboy : Employee
    {
        public Busboy(int employID, string empFirstName, string empLastName, int empHour, int empWage) : base(employID, empFirstName, empLastName, empHour, empWage, "Busboy")
        {
        }


    
        //private string tableStatus;

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