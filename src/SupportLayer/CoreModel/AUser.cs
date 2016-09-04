using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    public abstract class AUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public AUser CreateBy { get; set; }
        public ICollection<AUserRole> UserRole { get; set; }
        public AApp App { get; set; }
    }
}
