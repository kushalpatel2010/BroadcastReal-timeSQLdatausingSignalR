using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BroadcastReal_timeSQLdatausingSignalR
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            System.Data.SqlClient.SqlDependency.Start(ConfigurationManager.ConnectionStrings["NotificationConnection"].ConnectionString); 
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown 
            System.Data.SqlClient.SqlDependency.Stop(ConfigurationManager.ConnectionStrings["NotificationConnection"].ConnectionString);

        } 
    }
}
