using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel;
using SupportLayer.CoreModel.Abstraction;
using SupportLayer.Manager.App;
using SupportLayer.Manager.App.Handler;
using SupportLayer.Manager.Account;
using SupportLayer.DB;

namespace MRServerAPI.Model
{
    public class AccountFaced
    {
        private AppDbContext context = new AppDbContext();
        public AppUser CreateNewAccount(AUser user)
        {
            //get role
            var role = context.Roles.SingleOrDefault(e => e.Id == (int)SupportLayer.Enum.RoleType.Admin);
            //create App
            var pipe = new DefualtPipeForCreateApp();
            var app = new CDefualtApp();
            var factory = AppFactory.CreateApp<DefaultAppBuilder>(pipe);
            factory.CreateApp(app);
            //create User
            var cum = new CUserManager();
            cum.AddUser(user, app);
            cum.AddUserRole(user, role);
            cum.Save();
        }

        public AppUser AddNewAccount(AUser user)
        {

        }
    }
}
