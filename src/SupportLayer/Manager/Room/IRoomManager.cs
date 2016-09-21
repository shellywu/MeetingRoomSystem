using SupportLayer.CoreModel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Room.Abstraction
{
    public interface IRoomManager
    {
        ARoom AddRoom();
        bool DeleteRoom();
        ARoom EditRoom();
    }
}
