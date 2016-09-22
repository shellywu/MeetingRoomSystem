using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.ExtraModel.Abstraction
{
    public abstract class RoomInfo
    {
        public int Id { get; set; }
        public Dictionary<string, string> Infos { get; set; }
    }
}
