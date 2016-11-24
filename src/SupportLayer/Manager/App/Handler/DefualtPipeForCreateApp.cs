using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel.Abstraction;
using SupportLayer.Enum;

namespace SupportLayer.Manager.App.Handler
{
    public class DefualtPipeForCreateApp : IAppCreatePipe
    {
        public ModelEditType ModelEditType
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IAppCreatePipe Next
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Handle(AApp app)
        {
            throw new NotImplementedException();
        }
    }
}
