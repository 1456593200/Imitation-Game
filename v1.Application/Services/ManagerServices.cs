using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.Entities;
using v1.Infrastructure.DBContext;

namespace v1.Application.Services
{
    public class ManagerServices
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        public bool Login(string userName, string password)
        {

            EntityContext db = new EntityContext();
            var model = db.Managers.Where(p => p.user_name == userName & p.password == password);

            if (model.Count() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
