using PizzaShop.Models;
using PizzaShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace PizzaShop.Controllers
{
    public class MenuController : ApiController
    {
        private IMenuService svc = new MenuServiceImpl();
        //GET Method - /api/menu
        public List<Menu> GetMenu()
        {
            return svc.GetAllMenus();
        }

        //GET Method - /api/menu/id
        public Menu GetMenuById(int id)
        {
            return svc.GetMenuById(id);
        }

        // POST: api/menu
        public int CreateMenu([FromBody]Menu menu)
        {
            return svc.CreateMenu(menu);
        }

        // PUT: api/menu/id
        [HttpPut]
        public void UpdateMenuById(int id, [FromBody]Menu menu)
        {
            try
            {
                svc.UpdateMenubyId(id, menu);
            }
            catch (Exception ex)
            {
                HttpResponseMessage httpResponseMsg = new HttpResponseMessage(HttpStatusCode.NotFound);
                httpResponseMsg.Content = new StringContent(ex.Message);
                throw new HttpResponseException(httpResponseMsg);
            }
        }
    }
}
