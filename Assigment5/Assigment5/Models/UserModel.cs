using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assigment5.Models
{
    public class UserModel
    {
        [Required]
        public int Idd { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Nhập tối thiểu ít nhất 6 kí tự")]
        [DisplayName("Tên")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Nhập tối thiểu 5 kí tự")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Nhập tối thiểu 5 kí tự")]
        [DisplayName("Mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email cá nhân")]
        public string Email { get; set; }

    }
}