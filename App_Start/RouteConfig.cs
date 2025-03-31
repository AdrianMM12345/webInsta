using System.Web.Mvc;
using System.Web.Routing;

namespace webInstagram_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Instagram",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Instagram", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
