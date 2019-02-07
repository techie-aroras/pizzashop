using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaShop.Models;

namespace PizzaShop.Data
{
    public class StorageInMemory : IStorage
    {
        private static Dictionary<int, Menu> menuStore = new Dictionary<int, Menu>();
        private static Dictionary<int, Order> orderStore = new Dictionary<int, Order>();
       
        static StorageInMemory()
        {
            //OrderItems io1 = new OrderItems();
            //io1.ItemName = "Non Veg Pizza";
            //io1.ItemPrice = 11;
            //io1.Quantity = 2;
            //io1.itemTotal = io1.ItemPrice * io1.Quantity;

            //OrderItems io2 = new OrderItems();
            //io2.ItemName = "Veg Pizza";
            //io2.ItemPrice = 10;
            //io2.Quantity = 2;
            //io2.itemTotal = io2.ItemPrice * io2.Quantity;

            //OrderItems io3 = new OrderItems();
            //io3.ItemName = "Coke";
            //io3.ItemPrice = 2;
            //io3.Quantity = 4;
            //io3.itemTotal = io3.ItemPrice * io1.Quantity;

            //Order o1 = new Order();
            //o1.SetOrderId(100);
            //o1.SetOrderItems(new List<OrderItems> { io1, io2, io3 });

            //orderStore.Add(o1.GetOrderId(),o1);
            //Item i1 = new Item();
            //i1.ItemName = "Cheese Pizza";
            //i1.ItemPrice = 10;
            //i1.ItemCalories = 285;

            //Item i2 = new Item();
            //i2.ItemName = "Veggie Loverz Pizza";
            //i2.ItemPrice = 12;
            //i2.ItemCalories = 200;

            //Item i3 = new Item();
            //i3.ItemName = "Meat Loverz Pizza";
            //i3.ItemPrice = 12;
            //i3.ItemCalories = 250;

            //Item i4 = new Item();
            //i4.ItemName = "Coke";
            //i4.ItemPrice = 2;
            //i4.ItemCalories = 100;

            //Menu m1 = new Menu();
            //m1.SetMenuID(120);
            //m1.SetMenuItems(new List<Item>
            //{
            //    i1,i2
            //});

            //Menu m2 = new Menu();
            //m2.SetMenuID(130);
            //m2.SetMenuItems(new List<Item>
            //{
            //    i3,i4
            //});


            //menuStore.Add(m1.GetMenuID(), m1);
            //menuStore.Add(m2.GetMenuID(), m2);

        }

        public void CreateMenu(Menu menu)
        {
            menuStore.Add(menu.GetMenuID(),menu);
        }

        public void CreateOrder(Order order)
        {
            orderStore.Add(order.GetOrderId(), order);
        }

        public List<Menu> ReadAllMenus()
        {
           List<Menu> menuList = new List<Menu>();
           foreach(var menu in menuStore)
            {
                menuList.Add(menu.Value);
            }

            return menuList; 
        }

        public List<Order> ReadAllOrders()
        {
            List<Order> orderList = new List<Order>();
            foreach(var order in orderStore)
            {
                orderList.Add(order.Value);
            }

            return orderList;
        }

        public Menu ReadMenuById(int id)
        {
            return menuStore[id];
        }

        public Order ReadOrderById(int id)
        {
            return orderStore[id];
        }

        public void UpdateMenu(Menu menu)
        {
            menuStore[menu.GetMenuID()] = menu;
        }

        public void UpdateOrder(Order order)
        {
            orderStore[order.GetOrderId()] = order;
        }
    }
}