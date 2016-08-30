using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel
{
    public class CDefualtApp : AApp
    {
        public CDefualtApp()
        {
            base.AppId = Guid.NewGuid();
            base.Name = "默认应用名称";
        }
    }
}
