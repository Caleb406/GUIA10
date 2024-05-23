using System.Web;
using System.Web.Mvc;

namespace SitioWeb10_HR100621
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
