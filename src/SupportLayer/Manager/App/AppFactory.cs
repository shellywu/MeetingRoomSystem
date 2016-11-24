using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.App
{
    public class AppFactory
    {
        /// <summary>
        /// 根据一个处理管道及app管理器来创建一个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rootnode"></param>
        /// <param name="manageer"></param>
        /// <returns></returns>
        public static IAppManager CreateApp<T>(IAppCreatePipe rootnode) where T : IAppBuilder
        {
            ///为appManager添加处理管道
            var dab = Activator.CreateInstance<T>();
            dab.Add(rootnode);
            return dab.Builder();
        }
    }
}
