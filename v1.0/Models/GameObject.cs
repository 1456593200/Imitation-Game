using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v1._0.Models
{
    public class GameObject : BmobTable
    {

        private String fTable;
        //以下对应云端字段名称
        public String username { get; set; }
        public String password { get; set; }

        //构造函数
        public GameObject() { }

        //构造函数
        public GameObject(String tableName)
        {
            this.fTable = tableName;
        }

        public override string table
        {
            get
            {
                if (fTable != null)
                {
                    return fTable;
                }
                return base.table;
            }
        }

        //读字段信息
        public override void readFields(BmobInput input)
        {
            base.readFields(input);
            this.username = input.getString("username");
            this.password = input.getString("password");
        }

        //写字段信息
        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);
            output.Put("username", this.username);
            output.Put("password", this.password);
        }
    }
}