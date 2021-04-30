using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapPageRoute("default", "", "~/Modulos/Seguridad/Login.aspx");
            var settings = new FriendlyUrlSettings
            {
                AutoRedirectMode = RedirectMode.Permanent
            };
            routes.EnableFriendlyUrls(settings);
        }
    }
}
