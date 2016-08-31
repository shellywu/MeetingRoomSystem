using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel;

namespace SupportLayer.Manager.Account
{
    public class CSignManager : ASignManager
    {
        AUser _user = null;
        public CSignManager(AUser user)
        {
            _user = user;
        }
        public override Task<AUser> UserLogin(string email, string passwd)
        {
            _user.Name = email;
            _user.NickName = "wxl";
            return Task.FromResult(_user);

        }

        public override Task<AUser> UserLogin(int phone, string paawd)
        {
            throw new NotImplementedException();
        }
    }
}
