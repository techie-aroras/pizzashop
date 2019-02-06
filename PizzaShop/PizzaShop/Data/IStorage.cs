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
        List<Menu> ReadAllMenus();
        Menu ReadMenuById(int id);
        void CreateMenu(Menu menu);
        void UpdateMenu(Menu menu);
    }
}
