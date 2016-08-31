using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel;

namespace SupportLayer.Manager.Account
{
    public abstract class AUserManager : IUserManage, IUserRoleManage
    {
        public abstract bool AddUser(AUser user, AApp app);
        public bool AddUserRole(AUser user, AUserRole userRole)
        {
            if (user.UserRole.Contains(userRole)) return true;
            user.UserRole.Add(userRole);
            return true;
        }
        public abstract bool DeleteUser(AUser user);
        public abstract bool DeleteUserRole(AUser user, AUserRole userRole);
        public abstract bool IsExsit(AUser user);
        public abstract bool ModifyUser(AUser modifyUser);
    }
}
