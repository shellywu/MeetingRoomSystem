using SupportLayer.CoreModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Account
{
    public abstract class ASignManager : IUserLogin
    {
        public abstract Task<AUser> UserLogin(int phone, string paawd);

        public abstract Task<AUser> UserLogin(string email, string passwd);
    }
}
