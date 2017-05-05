using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Item : Menu
    {
        public static string hamburger = " Hamburger ";
        public static string doublepatty= " Double Patty ";
        public static string tomato= " Tomato ";
        public static string onions= " Onions ";
        public static string letttuce= " Lettuce ";
        public static string pickle = " Pickle ";
        public static string housesalad = " House Salad ";
        public static string gardensalad = " Garden Salad ";
        public static string fruitsalad = " Fruit Salad ";
        public static string plainsalad = " Plain Salad ";
        public static string coke = " Coke ";
        public static string sprite = " Sprite ";
        public static string rootbeer = " Root Beer ";
        public static string tea = " Tea ";
        public static int quantity;
        public static int c = 0;
        public static double runningTotal = 0D;
        public static double Tax = .0825;

        public static double Hamburgerprice()
        {
            return 15.75;
        }
        public static double doublepattyprice()
        {
            return 6.99;
        }
        public static double tomatoprice()
        {
            return 1.99;
        }
        public static double onionprice()
        {
            return 1.99;
        }
        public static double lettuceprice()
        {
            return 1.99;
        }
        public static double pickleprice()
        {
            return 1.99;
        }
        public static double housesaladprice()
        {
            return 5.99;
        }
        public static double gardensaladprice()
        {
            return 9.99;
        }
        public static double fruitsaladprice()
        {
            return 6.99;
        }
        public static double plainsaladprice()
        {
            return 2.99;
        }
        public static double cokeprice()
        {
            return 2.99;
        }
        public static double spriteprice()
        {
            return 2.99;
        }
        public static double rootbeerprice()
        {
            return 2.99;
        }
        public static double teaprice()
        {
            return 1.99;
        }
        

        public static int GetQuantity(int x)
        {
            return quantity += x; 
        }

        public void GetInventory()
        {
          
        }
    }
}