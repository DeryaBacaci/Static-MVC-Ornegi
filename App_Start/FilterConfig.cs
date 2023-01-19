using System.Web;
using System.Web.Mvc;

namespace Static_MVC_Ornegi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
