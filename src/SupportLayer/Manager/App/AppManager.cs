using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupportLayer.CoreModel.Abstraction;

namespace SupportLayer.Manager.App
{
    public class AppManager : IAppManager
    {
        public AApp CreateApp(AApp app)
        {
            var dapp = app as CoreModel.CDefualtApp;
            using (var db = new DB.AppDbContext())
            {
                db.Apps.Add(dapp);
                db.SaveChanges();
            }
            return dapp;
        }

        public AApp ModifyApp(AApp app)
        {
            var dapp = app as CoreModel.CDefualtApp;
            using (var dbstore = new DB.AppDbContext())
            {
                dbstore.Update(dapp);
                dbstore.SaveChanges();
            }
            return dapp;
        }
    }
}
