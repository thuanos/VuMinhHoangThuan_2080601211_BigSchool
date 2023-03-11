using System.Web;
using System.Web.Mvc;

namespace VuMinhHoangThuan_2080601211
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
