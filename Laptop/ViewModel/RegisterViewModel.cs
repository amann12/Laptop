using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laptop.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName{ get; set; }
        [Required]
        [EmailAddress]
        [Remote(action:"IsEmailUse",controller:"Account")]
        public string Email{ get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage = "Password Not Matched")]
        public string ConfirmPassword{ get; set; }

    }
}
