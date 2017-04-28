using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Host : Employee
    {
        private string tableStatus;

        public string TableStatus { get; set; }
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }

        //    set
        //    {
        //    }
        //}

        public void ChangeTableStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}