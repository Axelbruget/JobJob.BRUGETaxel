﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JobJobASPNET
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

            //routes.MapRoute(
            //    name: "List",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Offre", action = "List", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Details",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Offre", action = "Details", id = UrlParameter.Optional }
            //);
        }
    }
}