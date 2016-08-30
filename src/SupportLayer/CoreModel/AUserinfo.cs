using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel
{
    public abstract class AUserinfo
    {
        public abstract AUser User { get; set; }
        /// <summary>
        /// 不包括电话邮箱，因为电话邮箱常被用来登录
        /// </summary>
        public abstract ICollection<AContract> Contracts { get; set; }
    }
}
