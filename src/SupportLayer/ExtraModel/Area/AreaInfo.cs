using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.ExtraModel.Abstraction
{
    public class AreaIntroduction
    {
        public Guid Id { get; set; }
        public Area.APosition Position { get; set; }
        public string CustomeHtml { get; set; }
    }
}
