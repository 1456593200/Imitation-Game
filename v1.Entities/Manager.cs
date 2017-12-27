using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1.Entities
{
    /// <summary>
    /// 登陆用户信息类
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required, MaxLength(20)]
        public string user_name { get; set; }
        /// <summary>
        /// 登陆密码
        /// </summary>
        [Required, MaxLength(50)]
        public string password { get; set; }
    }
}
