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
    public class OrderController : ApiController
    {
        private IOrderService osvc = new OrderServiceImpl();
        //GET Method - /api/order
        public List<Order> GetOrders()
        {
            return osvc.GetAllOrders();
        }

        //GET Method - /api/order/id
        public Order GetOrderById(int id)
        {
            return osvc.GetOrderById(id);
        }

        // POST: api/order
        public int CreateOrder([FromBody]Order order)
        {
            return osvc.CreateOrder(order);
        }

        // PUT: api/order/id
        [HttpPut]
        public void UpdateOrderById(int id, [FromBody]Order order)
        {
            try
            {
                osvc.UpdateOrderbyId(id, order);
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
