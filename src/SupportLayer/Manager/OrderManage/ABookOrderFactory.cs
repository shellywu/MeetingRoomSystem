using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SupportLayer.CoreModel.Abstraction;

namespace SupportLayer.Manager.OrderManage.Abstraction
{
    /// <summary>
    ///根据不同的用户不用的房间产生不同的订单，
    ///使用抽象工厂是由于不同的资源会产生不同的订单
    /// </summary>
    public abstract class ABookOrderFactory
    {
        public AUser User { get; private set; }
        public ARoom Room { get; private set; }
        public AEvent Event { get; private set; }
        public ABookOrderFactory(AUser user, ARoom room, AEvent thing)
        {
            User = user;
            Room = room;
            Event = thing;
        }

        public abstract ABookOrder CreateOrder();
    }
}
