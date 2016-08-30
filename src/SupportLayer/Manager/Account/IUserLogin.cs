using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Account
{
    interface IUserLogin
    {
        bool UserLogin(string email,string passwd);
        bool UserLogin(int phone,string paawd);

    }
}
