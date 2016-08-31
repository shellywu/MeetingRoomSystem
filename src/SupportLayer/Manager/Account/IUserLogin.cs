using SupportLayer.CoreModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Account
{
    interface IUserLogin
    {
        Task<AUser> UserLogin(string email,string passwd);
        Task<AUser> UserLogin(int phone,string paawd) ;

    }
}
