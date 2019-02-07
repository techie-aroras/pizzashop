using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaShop.Models
{
    public class OrderItem
    {
        public string itemName;

        public string GetItemName()
        {
            return itemName;
        }

        public void SetItemName(string value)
        {
            itemName = value;
        }

        public double itemPrice;

        public double GetItemPrice()
        {
            return itemPrice;
        }

        public void SetItemPrice(double value)
        {
            itemPrice = value;
        }

        public int quantity;

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int value)
        {
            quantity = value;
        }

        public double itemTotal;

        public double GetItemTotal()
        {
            return itemTotal;
        }

        public void SetItemTotal(double value)
        {
            itemTotal = value;
        }
    }
}