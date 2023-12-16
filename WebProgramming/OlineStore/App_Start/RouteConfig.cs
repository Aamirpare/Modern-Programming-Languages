using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //Custom Route
            routes.MapRoute(
                "ProductionRoute",
                "Production/{year}/{month}",
                 new { controller = "Home", action = "ProductionByYear" }
            );

            routes.MapRoute(
                "StudentsRoute",
                "students",
                new { controller = "Home", action ="index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
