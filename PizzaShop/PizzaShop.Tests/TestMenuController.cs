using System;
using System.Web;
using System.Net;
using System.Collections.Generic;
using NUnit.Framework;
using PizzaShop.Models;
using PizzaShop.Controllers;
using System.Net.Http;

namespace PizzaShop.Tests
{
    [TestFixture]
    public class TestMenuController
    {
        public static Dictionary<int, Menu> menuStoreTest = new Dictionary<int, Menu>();
        [SetUp]
       public void SetUp()
        {
            Item i1 = new Item();
            i1.ItemName = "Cheese Pizza";
            i1.ItemPrice = 10;
            i1.ItemCalories = 285;

            Item i2 = new Item();
            i2.ItemName = "Veggie Loverz Pizza";
            i2.ItemPrice = 12;
            i2.ItemCalories = 200;

            Item i3 = new Item();
            i3.ItemName = "Meat Loverz Pizza";
            i3.ItemPrice = 12;
            i3.ItemCalories = 250;

            Item i4 = new Item();
            i4.ItemName = "Coke";
            i4.ItemPrice = 2;
            i4.ItemCalories = 100;

            Menu m1 = new Menu();
            m1.SetMenuID(120);
            m1.SetMenuItems(new List<Item>
            {
                i1,i2
            });

            Menu m2 = new Menu();
            m2.SetMenuID(130);
            m2.SetMenuItems(new List<Item>
            {
                i3,i4
            });


            menuStoreTest.Add(m1.GetMenuID(), m1);
            menuStoreTest.Add(m2.GetMenuID(), m2);
        }


        [Test]
        public void TestGetMenu()
        {
            //GetMenu method should return all the Menus.
            var controller = new MenuController();
            controller.Request = new HttpRequestMessage();


                
        }
    }
}
