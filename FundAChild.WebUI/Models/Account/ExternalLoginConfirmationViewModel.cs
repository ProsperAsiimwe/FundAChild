﻿using System.ComponentModel.DataAnnotations;

namespace FundAChild.WebUI.Models.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}