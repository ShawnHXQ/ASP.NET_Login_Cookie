﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieApplication.Pages
{
    [Authorize]
	public class ProductModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
