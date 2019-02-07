using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using PizzaShop.Data;
using PizzaShop.Models;

namespace PizzaShop.Service
{
    public class OrderServiceImpl : IOrderService
    {
        private IStorage storeOrders = new StorageInMemory();

        private static int orderIdSequence = 100;
        private static Order CalculateTotals(Order order)
        {
            order.SetTotalAmount(0);
            foreach (var orderItem in order.GetOrderItems())
            {
                orderItem.SetItemTotal(orderItem.GetQuantity() * orderItem.GetItemPrice());
                order.SetTotalAmount(orderItem.GetItemTotal() + order.GetTotalAmount());
            }
            return order;
        }
        public int CreateOrder(Order order)
        {
            order.SetOrderId(++orderIdSequence);
            storeOrders.CreateOrder(CalculateTotals(order));
            return orderIdSequence;
        }

        public List<Order> GetAllOrders()
        {
            return storeOrders.ReadAllOrders();
        }

        public Order GetOrderById(int id)
        {
            return storeOrders.ReadOrderById(id);
        }

        public void UpdateOrderbyId(int id, Order order)
        {
            if (orderIdSequence >= id)
            {
                order.SetOrderId(id);
                storeOrders.UpdateOrder(CalculateTotals(order));
            }
            else
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);     
        }
    }
}