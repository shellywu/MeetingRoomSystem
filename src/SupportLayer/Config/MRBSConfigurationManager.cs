using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Config
{
    public class MRBSConfigurationManager
    {
        private static Lazy<MRBSConfigurationManager> _instance = new Lazy<MRBSConfigurationManager>();
        public static MRBSConfigurationManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public MRBSConfigurationManager(IDBConfig config)
        {
            ConnectionString = config.Connection;
        }
        public string ConnectionString { get; set; }

    }
}
