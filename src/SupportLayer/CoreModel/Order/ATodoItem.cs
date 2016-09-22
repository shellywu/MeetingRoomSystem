using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Order.Abstraction
{
    public abstract class ATodoItem
    {
        public int Id { get; set; }

        public ICollection<CoreModel.Abstraction.AUser> Users { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ThingDescribe { get; set; }
    }
}
