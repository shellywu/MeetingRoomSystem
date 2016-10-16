using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    /// <summary>
    /// 为房间提供一个更高层次的组织结构，方便对房间的整体处理
    /// </summary>
    public abstract class AArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enum.RoomStatus Status { get; set; }
        public string AdminEmail { get; set; }
        public AreaConfig Config { get; set; }
        public ExtraModel.Abstraction.AreaInfo AreaInfo { get; set; }
    }
}
