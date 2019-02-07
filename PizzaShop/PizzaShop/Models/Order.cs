using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaShop.Models
{
    [Serializable]
    public class Order
    {
        private int orderId;

        public int GetOrderId()
        {
            return orderId;
        }

        public void SetOrderId(int value)
        {
            orderId = value;
        }

        private List<OrderItem> orderItems;

        public List<OrderItem> GetOrderItems()
        {
            return orderItems;
        }

        public void SetOrderItems(List<OrderItem> value)
        {
            orderItems = value;
        }

        private double totalAmount;

        public double GetTotalAmount()
        {
            return totalAmount;
        }

        public void SetTotalAmount(double value)
        {
            totalAmount = value;
        }
    }
}