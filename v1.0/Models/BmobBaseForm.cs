using cn.bmob.api;
using cn.bmob.tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace v1._0.Models
{
    public class BmobBaseForm
    {
        //创建Bmob实例
        private BmobWindows bmob;

        public BmobBaseForm()
            : base()
        {
            bmob = new BmobWindows();

            //初始化，这个ApplicationId/RestKey需要更改为你自己的ApplicationId/RestKey（ http://www.bmob.cn 上注册登录之后，创建应用可获取到ApplicationId/RestKey）
            Bmob.initialize("69e01e36e091bee65ebeb8f93604f474", "8b0d500c09ff5c86cfcd3358b5104b05");

            //注册调试工具
            BmobDebug.Register(msg => { Debug.WriteLine(msg); });
        }

        public BmobWindows Bmob
        {
            get { return bmob; }
        }
    }
}