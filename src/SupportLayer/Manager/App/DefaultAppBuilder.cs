using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.App
{
    public class DefaultAppBuilder : IAppBuilder
    {
        private IAppCreatePipe _pipeStart = null;
        private AppManagerProxy _appManagerProxy = null;
        public DefaultAppBuilder()
        {
            _appManagerProxy =new AppManagerProxy(new AppManager());
        }
        public void Add(IAppCreatePipe pipeHandler)
        {
            _pipeStart = pipeHandler;
        }

        public IAppManager Builder()
        {
            _appManagerProxy.HandelPipe = _pipeStart;
            return _appManagerProxy;
        }
    }
}
