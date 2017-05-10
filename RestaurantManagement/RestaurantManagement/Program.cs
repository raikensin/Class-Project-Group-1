// Group 1 Project
// 05/09/2017
// COSC 2330 - 002
// Final Project Team 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MenuForm());
            Application.Run(new Login());
           // Application.Run(new KitchenScreen());
        }
    }
}
