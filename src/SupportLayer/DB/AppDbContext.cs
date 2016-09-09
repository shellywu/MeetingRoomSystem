using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupportLayer.CoreModel;

namespace SupportLayer.DB
{
    public class AppDbContext:DbContext
    {
        public DbSet<CDefualtApp> Apps { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoleMap> UserRoleMap { get; set; }
    }
}
