﻿using System.ComponentModel.DataAnnotations;

namespace WebApplicationNicola.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        [Display(Name = "Please Enter Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Please Enter Password")]
        public string Password { get; set; }

        public int isActive { get; set; }
    }
}
