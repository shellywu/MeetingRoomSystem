using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SupportLayer.CoreModel.Abstraction;
using SupportLayer.CoreModel;

namespace SupportLayer.Manager.Account
{
    interface IUserRoleManage
    {
        bool AddUserRole(AUser user, AUserRole userRole);
        bool DeleteUserRole(AUser user, AUserRole userRole);
    }
}
