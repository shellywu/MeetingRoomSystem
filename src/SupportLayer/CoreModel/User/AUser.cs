using SupportLayer.Manager.Room.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    public abstract class AUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="名称有误",AllowEmptyStrings =false), MaxLength(32,ErrorMessage ="最大长度为32字符"), MinLength(1,ErrorMessage ="最少为一个字符")]
        public string Name { get; set; }
        [MaxLength(32), MinLength(0)]
        public string NickName { get; set; }
        [Required, MaxLength(11), MinLength(11), Phone]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Mail格式错误"), EmailAddress]
        public string Email { get; set; }
        [Required, MaxLength(20), MinLength(8)]
        public string Password { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public AUser CreateBy { get; set; }

        public abstract AUserRole Role { get; set; }
        public abstract AApp App { get; set; }


    }
}
