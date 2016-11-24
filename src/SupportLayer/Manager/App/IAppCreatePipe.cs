using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.App
{
    public interface IAppCreatePipe
    {
        /// <summary>
        /// 管道中下一个节点
        /// </summary>
        IAppCreatePipe Next { get; }

        Enum.ModelEditType ModelEditType { get; set; }
        /// <summary>
        /// 处理事项
        /// </summary>
        /// <param name="app"></param>
        void Handle(CoreModel.Abstraction.AApp app);
    }
}
