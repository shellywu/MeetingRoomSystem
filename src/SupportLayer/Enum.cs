using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Enum
{
    public enum VisibleType : int
    {
        /// <summary>
        /// a room is visible for everyone
        /// </summary>
        Anyone = 0,
        /// <summary>
        /// a room is visible for one who has permision 
        /// </summary>
        Sepcial = 1,
        /// <summary>
        /// a room is visible for myself only
        /// </summary>
        Hidden = 2
    }

    public enum RoomStatus : int
    {
        /// <summary>
        /// 房间或地区不可用
        /// </summary>
        Disable = 0,
        /// <summary>
        /// 房间地区可用
        /// </summary>
        Online = 1,
        /// <summary>
        /// 房间地区暂时不可用
        /// </summary>
        Offline = 2
    }
}
