using System.Web;
using System.Web.Mvc;

namespace DuongMinhMan_23DH112038
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
