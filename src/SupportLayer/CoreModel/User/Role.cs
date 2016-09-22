using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel
{
    public class Role : Abstraction.AUserRole
    {
        public string DisplayName { get; set; }
        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}
