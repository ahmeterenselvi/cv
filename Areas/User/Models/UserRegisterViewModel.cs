using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.User.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soy Adınızı Giriniz.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
        [Compare(nameof(Password), ErrorMessage = "Şifreniz İlk Şifreyle Aynı Değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Hesabı Giriniz.")]
        [EmailAddress]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Url'si Giriniz.")]
        public string ImageUrl { get; set; }
    }
}
