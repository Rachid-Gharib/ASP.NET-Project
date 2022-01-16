using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Projet_Web_MVC_avec_fichier___CRUD {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Ajouter",
                url: "Ajouter",
                defaults: new {
                    controller = "Membres",
                    action = "Ajouter",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Enregistrer",
                url: "Enregistrer",
                defaults: new {
                    controller = "Membres",
                    action = "Enregistrer",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "ListerTout",
                url: "ListerTout",
                defaults: new {
                    controller = "Membres",
                    action = "ListerTout",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Index",
                url: "Index",
                defaults: new {
                    controller = "Membres",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Membres",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
