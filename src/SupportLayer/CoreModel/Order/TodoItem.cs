using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Order
{
    public class TodoItem : Abstraction.ATodoItem
    {
        public string Remark { get; set; }
        public int Priorty { get; set; }

        public bool NeedNotify { get; set; }
    }
}
