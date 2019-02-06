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

        private List<OrderItems> orderItems;

        public List<OrderItems> GetOrderItems()
        {
            return orderItems;
        }

        public void SetOrderItems(List<OrderItems> value)
        {
            orderItems = value;
        }

        private double totalAmount;

        public double GetTotalAmount()
        {
            return totalAmount;
        }

        private void SetTotalAmount(double value)
        {
            totalAmount = value;
        }
    }
}