﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeDetails
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "Employees",
            //    "{Employee}/{action}",
            //    new { controller = "Employee", action = "GetEmployee", id = UrlParameter.Optional }
            //    );

            //routes.MapRoute(
            //    "Employee",
            //    "Employee/{id}",
            //    new { controller = "Employee", action = "GetEmployee", id = "" }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "GetEmployee", id = UrlParameter.Optional }
            );
        }
    }
}
