using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //Add restriction globally to force the user to login
            filters.Add(new AuthorizeAttribute());

            //Force to use HTTPS
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
