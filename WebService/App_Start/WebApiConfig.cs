using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
          

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            // Web API configuration and services

           
            EnableCorsAttribute cors = new EnableCorsAttribute("http://localhost:4200", "Accept, Origin, Content-Type, X-Auth-Token, cache-control, x-requested-with", "GET, POST ,PATCH, PUT, DELETE, OPTIONS");

            cors.SupportsCredentials = true;
            config.EnableCors(cors);
        }
    }
}
