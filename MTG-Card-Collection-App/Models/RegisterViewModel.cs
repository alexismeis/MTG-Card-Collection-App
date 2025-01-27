﻿using System.ComponentModel.DataAnnotations;

namespace MTG_Card_Collection_App.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required (ErrorMessage = "Please confirm you password.")]
        [DataType (DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
