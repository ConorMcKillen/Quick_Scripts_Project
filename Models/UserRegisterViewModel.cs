﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using QSProject.Data.Models;


namespace QSProject.Models
{
    // need separate register view model for register remote validation which is not needed in login
    public class UserRegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote("VerifyEmailAddress", "User")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match. Type again!")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        public string Name { get; set; }

    
    }
}
