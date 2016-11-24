using System;
using System.Collections.Generic;

namespace SupportLayer.CoreModel.Abstraction
{
    /// <summary>
    /// 用于分享后邀请其他人加入的唯一标识
    /// </summary>
    public abstract class AApp
    {
        public Guid AppId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AUser>  Users { get; set; }
    }
}
