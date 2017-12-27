using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1.Entities;

namespace v1.Infrastructure.DBContext
{
    public class EntityContext:DbContext
    {
        public EntityContext() : base("name=ConnectionString")
        {          
        }

        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 禁用表名自动复数规则
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
