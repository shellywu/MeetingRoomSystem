using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.App
{
    public interface IAppBuilder
    {
        /// <summary>
        /// 添加处理管道
        /// </summary>
        /// <param name="pipe"></param>
        void Add(IAppCreatePipe pipe);
        /// <summary>
        /// 构建管道
        /// </summary>
        /// <returns></returns>
        IAppManager Builder();
    }
}
