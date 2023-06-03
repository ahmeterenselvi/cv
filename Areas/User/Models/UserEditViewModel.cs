using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.User.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }
    }
}
