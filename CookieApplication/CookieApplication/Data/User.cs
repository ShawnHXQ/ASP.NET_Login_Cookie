using System;
using System.ComponentModel.DataAnnotations;

namespace CookieApplication.Data
{
	public class User
	{
		[Key]
        [Display(Name = "UserId")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

}

