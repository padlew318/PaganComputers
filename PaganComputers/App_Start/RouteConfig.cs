﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PaganComputers
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tutorials",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Tutorials", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "More",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "More", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
