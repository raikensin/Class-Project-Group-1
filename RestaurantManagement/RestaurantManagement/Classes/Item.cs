using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Item : Menu
    {
        private string hamburger = " Hamburger ";
        private string doublepatty= " Double Patty ";
        private string tomato= " Tomato ";
        private string onions= " Onions ";
        private string letttuce= " Lettuce ";
        private string pickle = " Pickle ";
        private string housesalad = " House Salad ";
        private string gardensalad = " Garden Salad ";
        private string fruitsalad = " Fruit Salad ";
        private string plainsalad = " Plain Salad ";
        private string coke = " Coke ";
        private string sprite = " Sprite ";
        private string rootbeer = " Root Beer ";
        private string tea = " Tea ";
        public static int quantity;
        public static int c = 0;
        public double runningTotal = 0D;
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
            throw new System.NotImplementedException();
        }
    }
}