using System.Collections.Generic;
using System;

namespace PizzaShop.Models
{
    [Serializable]
    public class Menu
    {
        private int menuID;

        public int GetMenuID()
        {
            return menuID;
        }

        public void SetMenuID(int value)
        {
            menuID = value;
        }

        private List<Item> menuItems;

        public List<Item> GetMenuItems()
        {
            return menuItems;
        }

        public void SetMenuItems(List<Item> value)
        {
            menuItems = value;
        }
    }
}