using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KayıtProgramı.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Passsword { get; set; }

        [Compare(nameof(Passsword), ErrorMessage = "Passwords don't match.")]
        public string RePassword { get; set; }


    }
}