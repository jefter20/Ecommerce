using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuration
{
    public class ContextBase : IdentityDbContext<AplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Product> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=DESKTOP-0GV4J10\\SQLEXPRESS;Initial Catalog=ECOMMERCE;Integrated Security=SSPI;Persist Security Info=False";
            return strCon;
        }
    }
}
