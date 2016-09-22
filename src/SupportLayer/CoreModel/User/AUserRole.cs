using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    /// <summary>
    /// 用于角色的抽象
    /// </summary>
    public abstract class AUserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
