using PizzaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Service
{
    interface IMenuService
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        int CreateMenu(Menu menu);
        void UpdateMenubyId(int id, Menu menu);
    }
}
