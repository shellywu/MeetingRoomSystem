using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    /// <summary>
    /// 需要通知哪些人，需要备注哪些事情，需要做哪些准备
    /// </summary>
    public abstract class AEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Describe { get; set; }
        /// <summary>
        /// pre requre things to do
        /// </summary>
        public ICollection<Order.Abstraction.ATodoItem> PreTodoList { get; set; }
    }
}
