using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PizzaShop
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "MenuApi",
                routeTemplate: "api/Menu/{id}",
                defaults: new {controller = "Menu",id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "OrderApi",
                routeTemplate: "api/Order/{id}",
                defaults: new { controller = "Order", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
