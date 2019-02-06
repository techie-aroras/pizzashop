using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaShop.Data;
using PizzaShop.Models;

namespace PizzaShop.Service
{
    public class MenuServiceImpl : IMenuService
    {
        private IStorage store = new StorageInMemory();
        private static int menuIdSequence = 0;

        public int CreateMenu(Menu menu)
        {
            menu.SetMenuID(++menuIdSequence);
            store.CreateMenu(menu);
            return menuIdSequence;
        }

        public List<Menu> GetAllMenus()
        {
            return store.ReadAllMenus();
        }

        public Menu GetMenuById(int id)
        {
            return store.ReadMenuById(id);
        }

        public void UpdateMenubyId(int id, Menu menu)
        {
            menu.SetMenuID(id);
            store.UpdateMenu(menu);

        }
    }
}