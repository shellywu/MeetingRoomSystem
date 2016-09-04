using SupportLayer.Manager.Token.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    public class CTokenParameters : ATokenParameters
    {
        public override string Path
        {
            get
            {
                return "/token";
            }
        }
    }
}
