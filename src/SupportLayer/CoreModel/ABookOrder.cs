using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    /// <summary>
    /// 何人在何时由于何时预定一间会议室
    /// </summary>
    public abstract class ABookOrder
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public AUser User { get; private set; }
        public ARoom Room { get; private set; }
        public AEvent EventThing { get; private set; }

        public string Remark { get; set; }

        public ABookOrder(AUser user, ARoom room, AEvent thing)
        {
            User = user;
            Room = room;
            EventThing = thing;
        }
        /// <summary>
        /// 预定房间
        /// </summary>
        /// <param name="user">预定人</param>
        /// <param name="room">房间</param>
        /// <param name="thing">事情</param>
        /// <returns></returns>
        public abstract bool BookOrder();
        public abstract bool CancelOrder();
        public abstract bool EditOrder(AUser user, ARoom room, AEvent thing);
    }
}
