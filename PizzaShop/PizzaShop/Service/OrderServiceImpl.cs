using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaShop.Data;
using PizzaShop.Models;

namespace PizzaShop.Service
{
    public class OrderServiceImpl : IOrderService
    {
        private IStorage storeOrders = new StorageInMemory();

        public int CreateOrder(Order order)
        {
            storeOrders.CreateOrder(order);
            return 0;
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
            order.SetOrderId(id);
            storeOrders.UpdateOrder(order);
        }
    }
}