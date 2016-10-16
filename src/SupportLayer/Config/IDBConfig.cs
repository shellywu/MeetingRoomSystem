using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Config
{
    public interface IDBConfig
    {
        string Connection { get; set; }
        void SetConnection();
    }
}
