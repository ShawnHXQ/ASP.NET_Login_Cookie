using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieApplication.Pages.Account
{
	public class RegisterConfirmationModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RegisterConfirmationModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public string Email { get; set; }


        public async Task<IActionResult> OnGetAsync(string email)
        {
            if(email == null)
            {
                return RedirectToPage("/Index"); 
            }
            var user = _context.Users.Where(f => f.Email == email).FirstOrDefault();
            if(user == null)
            {
                return NotFound($"Unable to load user with email '{email}'."); 
            }
            Email = email;
            return Page(); 
        }
    }
}
