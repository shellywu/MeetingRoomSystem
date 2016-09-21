using SupportLayer.ExtraModel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    public abstract class ARoom
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MinSize { get; set; }
        public int MaxSize{ get; set; }
        public AArea Area { get; set; }
        public RoomInfo RoomInfo { get; set; }
    }
}
