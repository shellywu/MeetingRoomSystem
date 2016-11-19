using SupportLayer.CoreModel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.App
{
    /// <summary>
    /// 只负责创建app和修改app
    /// </summary>
    public interface IAppManager
    {
        AApp CreateApp(AApp app);
        AApp ModifyApp(AApp app);
    }
}
