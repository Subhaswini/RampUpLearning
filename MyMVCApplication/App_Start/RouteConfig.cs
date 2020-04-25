using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMVCApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "MusicStore",
            url: "MusicStore/{action}/{id}",
            defaults: new { controller = "MusicStore", action = "Music", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Employee",
            url: "Employee/{action}/{name}",
            defaults: new { controller = "Employee", action = "Search", name = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Travel",
            url: "Travel/{action}",
            defaults: new { controller = "Travel", action = "Index" }
            );

            routes.MapRoute(
            name: "Customer",
            url: "Customer/{action}",
            defaults: new { controller = "Customer", action = "Index" }
            );

            routes.MapRoute(
            name: "Student",
            url: "Student/{action}",
            defaults: new { controller = "Student", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Travel", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
