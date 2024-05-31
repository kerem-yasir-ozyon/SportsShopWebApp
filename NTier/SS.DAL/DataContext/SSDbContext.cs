using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SS.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.DAL.DataContext
{
    public class SSDbContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public SSDbContext(DbContextOptions<SSDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
