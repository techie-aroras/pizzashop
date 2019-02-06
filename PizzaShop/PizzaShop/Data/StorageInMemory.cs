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

        static StorageInMemory()
        {
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

        public List<Menu> ReadAllMenus()
        {
           List<Menu> menuList = new List<Menu>();
           foreach(var menu in menuStore)
            {
                menuList.Add(menu.Value);
            }

            return menuList; 
        }

        public Menu ReadMenuById(int id)
        {
            return menuStore[id];
        }

        public void UpdateMenu(Menu menu)
        {
            menuStore[menu.GetMenuID()] = menu;
        }
    }
}