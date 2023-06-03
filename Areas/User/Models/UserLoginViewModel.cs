using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.User.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="UserName")]
        [Required(ErrorMessage ="Kullanıcı adı giriniziz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre giriniziz.")]
        public string Password { get; set; }
    }
}
