using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.OrderEnum
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
}
