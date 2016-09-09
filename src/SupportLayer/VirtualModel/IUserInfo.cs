using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SupportLayer.CoreModel;
using SupportLayer.CoreModel.Abstraction;

namespace SupportLayer.VirtualModel
{
    interface IUserInfo
    {
        AUserinfo GetUserInfo(Guid uid);
    }
}
