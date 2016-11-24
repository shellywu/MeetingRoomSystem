using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel;
using SupportLayer.CoreModel.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace SupportLayer.Manager.Account.Abstraction
{
    public abstract class AUserManager : IUserManage, IUserRoleManage
    {
        public abstract DbContext Context { get; }
        public abstract bool AddUser(AUser user, AApp app);
        public abstract bool AddUserRole(AUser user, AUserRole userRole);
        public abstract bool DeleteUser(AUser user);
        public abstract bool DeleteUserRole(AUser user, AUserRole userRole);
        public abstract bool IsExsit(AUser user);
        public abstract bool ModifyUser(AUser modifyUser);

        public void Save() {
            Context.SaveChanges();
        }
    }
}
