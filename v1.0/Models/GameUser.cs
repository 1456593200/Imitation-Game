using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v1._0.Models
{
    public class GameUser : BmobUser
    {

        public BmobInt life { get; set; }
        public BmobInt attack { get; set; }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);

            output.Put("life", this.life);
            output.Put("attack", this.attack);
        }

        public override void readFields(BmobInput input)
        {
            base.readFields(input);

            this.life = input.getInt("life");
            this.attack = input.getInt("attack");
        }
    }
}