using System;
using Microsoft.EntityFrameworkCore;

namespace CookieApplication.Data
{
	public class ApplicationDbContext:DbContext
	{
  
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<User> Users { get; set; }
    
    }
}

