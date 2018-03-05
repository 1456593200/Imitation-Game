using cn.bmob.api;
using cn.bmob.io;
using cn.bmob.tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using v1._0.Models;
using v1.Application.Services;
using v1.Entities.Initializer;
using v1.Infrastructure.DBContext;

namespace v1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public void LoginIn()
        {
            string UserName = Request["txt_account"];  //获取输入的用户名
            string UserPwd = Request["txt_password"];  //获取输入的密码

            BmobUser user = new BmobUser();
            BmobWindows bmob = new BmobWindows();
            bmob.Login<BmobUser>(UserName, UserPwd, (resp, exception) =>
            {
                if (exception != null)
                {
                    Debug.WriteLine("登录失败, 失败原因为： " + exception.Message);
                    return;
                }
                Response.Write("<script>window.location.href='https://www.baidu.com/'</script>");
                Debug.WriteLine("登录成功, 当前用户对象Session： " + BmobUser.CurrentUser.sessionToken);

            });

            //try
            //{
            //    if (UserName == "admin")
            //        return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功。" }.ToJson());
            //    else if (UserPwd == "123456")
            //        return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功。" }.ToJson());
            //    else
            //        return Content(new AjaxResult { state = ResultType.error.ToString(), message = "请验证帐号及密码！" }.ToJson());
            //}

            //catch (Exception ex)
            //{
            //    return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message }.ToJson());
            //}
        }
    }
}