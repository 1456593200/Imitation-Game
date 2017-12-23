using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public int LoginIn(string UserName1, string UserPwd1)
        {
            if (UserName1 == "admin" && UserPwd1 == "123456")
            {
                return 200;     //登陆成功
            }
            return 0;             //登陆失败
        }
    }
}