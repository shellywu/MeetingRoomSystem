using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel;

namespace SupportLayer.Manager.Account
{
    public class CUserManager : AUserManager
    {
        public override bool AddUser(AUser user, AApp app)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteUser(AUser user)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteUserRole(AUser user, AUserRole userRole)
        {
            throw new NotImplementedException();
        }

        public override bool IsExsit(AUser user)
        {
            user.Name = "wxl";
            user.NickName = "hello world";
            return true;
        }

        public override bool ModifyUser(AUser modifyUser)
        {
            throw new NotImplementedException();
        }
    }
}
