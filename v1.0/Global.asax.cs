using cn.bmob.api;
using cn.bmob.tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace v1._0
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BmobWindows Bmob = new BmobWindows();
            Bmob.initialize("69e01e36e091bee65ebeb8f93604f474", "8b0d500c09ff5c86cfcd3358b5104b05");
            BmobDebug.Register(msg => { Debug.WriteLine(msg); });   //注册调试工具
        }
    }
}
