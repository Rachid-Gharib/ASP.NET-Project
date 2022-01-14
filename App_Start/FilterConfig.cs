using System.Web;
using System.Web.Mvc;

namespace Projet_Web_MVC_avec_fichier___CRUD {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
