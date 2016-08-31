using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SupportLayer.CoreModel;

namespace SupportLayer.Manager.Account
{
    interface IUserManage
    {
        bool AddUser(AUser user,AApp app);
        bool ModifyUser(AUser modifyUser);
        bool DeleteUser(AUser user);
        bool IsExsit(AUser user);
    }
}
