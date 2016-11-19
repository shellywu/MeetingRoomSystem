using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.ExtraModel.Area
{
    public abstract class APosition
    {
        /// <summary>
        /// 经度
        /// </summary>
        public decimal Longitude { get; set; }
        /// <summary>
        /// 维度
        /// </summary>
        public decimal Dimension { get; set; }

    }
}
