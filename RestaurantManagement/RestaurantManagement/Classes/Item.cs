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
        private int quantity;
        public double runningTotal = 0D;

        public double Hamburgerprice()
        {
            return 15.75;
        }
        public double doublepattyprice()
        {
            return 6.99;
        }
        public double tomatoprice()
        {
            return 1.99;
        }
        public double onionprice()
        {
            return 1.99;
        }
        public double lettuceprice()
        {
            return 1.99;
        }
        public double pickleprice()
        {
            return 1.99;
        }
        public double housesaladprice()
        {
            return 5.99;
        }
        public double gardensaladprice()
        {
            return 9.99;
        }
        public double fruitsaladprice()
        {
            return 6.99;
        }
        public double plainsaladprice()
        {
            return 2.99;
        }
        public double cokeprice()
        {
            return 2.99;
        }
        public double spriteprice()
        {
            return 2.99;
        }
        public double rootbeerprice()
        {
            return 2.99;
        }
        public double teaprice()
        {
            return 1.99;
        }
        

        public int Quantity
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void GetInventory()
        {
            throw new System.NotImplementedException();
        }
    }
}