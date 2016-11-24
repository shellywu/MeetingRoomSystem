using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel;
using SupportLayer.Manager.Account.Abstraction;
using SupportLayer.CoreModel.Abstraction;
using SupportLayer.DB;
using Microsoft.EntityFrameworkCore;

namespace SupportLayer.Manager.Account
{
    public class CUserManager : AUserManager
    {
        private AppDbContext context = new AppDbContext();
        public CUserManager()
        {
        }

        public override DbContext Context
        {
            get
            {
                return context;
            }
        }

        public override bool AddUser(AUser user, AApp app)
        {
            user.App = app;
            context.Users.Add(user as AppUser);
            return true;
        }

        public override bool AddUserRole(AUser user, AUserRole userRole)
        {
            var urmap = new UserRoleMap() { User = user as AppUser, Role = userRole as Role };
            context.UserRoleMap.Add(urmap);
            return true;
        }

        public override bool DeleteUser(AUser user)
        {
            context.Users.Remove(user as AppUser);
            return true;
        }

        public override bool DeleteUserRole(AUser user, AUserRole userRole)
        {
            context.UserRoleMap.Remove(new UserRoleMap { User = user as AppUser, Role = userRole as Role });
            return true;
        }

        public override bool IsExsit(AUser user)
        {
            var r = context.Users.Where(e => e.Name.Equals(user.Name) && e.Password.Equals(user.Password)).Count();
            return r > 0 ? true : false;
        }

        public override bool ModifyUser(AUser modifyUser)
        {
            context.Users.Update(modifyUser as AppUser);
            return true;
        }
    }
}
