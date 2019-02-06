using PizzaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Data
{
    interface IStorage
    {
        //Menu
        List<Menu> ReadAllMenus();
        Menu ReadMenuById(int id);
        void CreateMenu(Menu menu);
        void UpdateMenu(Menu menu);

        //Order
        List<Order> ReadAllOrders();
        Order ReadOrderById(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
    }
}
