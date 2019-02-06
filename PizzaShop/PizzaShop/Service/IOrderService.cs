using PizzaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Service
{
    interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        int CreateOrder(Order order);
        void UpdateOrderbyId(int id, Order order);
    }
}
