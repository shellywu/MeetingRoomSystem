using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel.Abstraction;

namespace SupportLayer.Manager.OrderManage
{
    public class InternalBookOrderFactory : Abstraction.ABookOrderFactory
    {
        public InternalBookOrderFactory(AUser user, ARoom room, AEvent thing) : base(user, room, thing)
        {
        }

        public override ABookOrder CreateOrder()
        {
            
        }
    }
}
