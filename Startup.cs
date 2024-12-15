using System;
using System.Web;
using System.Web.Routing;

namespace TonNamespace
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code qui s'exécute au démarrage de l'application
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("BonjourRoute", "bonjour", "~/Bonjour.aspx");
        }
    }
}
