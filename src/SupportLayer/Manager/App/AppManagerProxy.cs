using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel.Abstraction;

namespace SupportLayer.Manager.App
{
    public class AppManagerProxy : IAppManager
    {
        private IAppManager _appManager = null;

        public AppManagerProxy(IAppManager appmanager)
        {
            _appManager = appmanager;
        }

        public IAppCreatePipe HandelPipe
        {
            get;

            set;
        }

        public AApp CreateApp(AApp app)
        {
            _appManager.CreateApp(app);
            HandelPipe.ModelEditType = Enum.ModelEditType.Create;
            HandelPipe.Handle(app);
            return app;
        }

        public AApp ModifyApp(AApp app)
        {
            _appManager.ModifyApp(app);
            HandelPipe.ModelEditType = Enum.ModelEditType.Edit;
            HandelPipe.Handle(app);
            return app;
        }
    }
}
