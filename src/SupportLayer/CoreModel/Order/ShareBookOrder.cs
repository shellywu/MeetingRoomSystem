using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Order
{
    public class ShareBookOrder:CoreModel.Abstraction.ABookOrder
    {
        /// <summary>
        /// share room by web qrcode
        /// </summary>
        public Guid ShareId { get; set; }

        public CoreModel.Abstraction.AUser ShareMan { get; set; }
        public ICollection<CoreModel.Abstraction.AUser> ReciverMan { get; set; }
    }
}
