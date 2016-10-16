using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupportLayer.CoreModel;
using SupportLayer.CoreModel.Abstraction;
using SupportLayer.Config;

namespace SupportLayer.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(MRBSConfigurationManager.Instance.ConnectionString);
        }

        public DbSet<CDefualtApp> Apps { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoleMap> UserRoleMap { get; set; }
    }
}
