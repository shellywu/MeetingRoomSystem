using SupportLayer.CoreModel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Account.Abstraction
{
    interface IUserLogin
    {
        Task<AUser> UserLogin(string email,string passwd);
        Task<AUser> UserLogin(int phone,string paawd) ;

    }
}
