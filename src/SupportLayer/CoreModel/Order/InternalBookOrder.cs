using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Order
{
    public class InternalBookOrder :CoreModel.Abstraction.ABookOrder
    {
        public Enum.VisibleType VisibleType { get; set; }
        /// <summary>
        /// define the one who has permisson
        /// </summary>
        public ICollection<CoreModel.Abstraction.AUserRole> VisitorRole { get; set; }

        /// <summary>
        /// when this propority is true,everyone is allowd to get the reson for order 
        /// </summary>
        public bool EventVisible { get; set; }
    }
}
