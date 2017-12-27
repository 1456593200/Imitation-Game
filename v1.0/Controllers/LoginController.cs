using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using v1._0.Models;
using v1.Application.Services;
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
        public ActionResult LoginIn(string UserName, string UserPwd)
        {
            var result = new ManagerServices().Login(UserName, UserPwd);
            if(result)
            {
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功。" }.ToJson());
            }
            else
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = "请验证帐号及密码！" }.ToJson());
            }
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