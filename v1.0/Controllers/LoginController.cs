using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using v1._0.Models;

namespace v1.Controllers
{
    public class LoginController : Controller
    {


        public const String TABLE_NAME = "dt_admin";
        private GameObject gameObject = new GameObject(TABLE_NAME);

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
            //创建一个BmobQuery查询对象
            BmobQuery query = new BmobQuery();

            if (query.WhereEqualTo("userName", UserName1).ToString()!=""&& query.WhereEqualTo("userName", UserName1).ToString()!="")
            {
                return 200;     //登陆成功
            }
            return 0;             //登陆失败
        }
    }
}