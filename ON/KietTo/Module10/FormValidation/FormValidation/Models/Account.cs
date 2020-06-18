﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class Account
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username { get; set; }
        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-x])(?=.*[A-Z]).{6,20})")]
        public string Password { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
