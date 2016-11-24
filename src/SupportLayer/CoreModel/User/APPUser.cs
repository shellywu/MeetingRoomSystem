using SupportLayer.CoreModel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel
{
    public class AppUser:AUser
    {
        private Role _userRole;
        private CDefualtApp _app;

        public override AUserRole Role
        {
            get
            {
                return _userRole;
            }

            set
            {
                if (value is Role) {
                    _userRole = value as Role;
                    return;
                }
                throw new ArgumentException("对象错误");
            }
        }

        public override AApp App
        {
            get
            {
                return _app;
            }

            set
            {
                if (value is CDefualtApp) {
                    _app = value as CDefualtApp;
                    return;
                }
                throw new ArgumentException("对象错误");
            }
        }
    }
}
