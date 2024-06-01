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
    public class SSDbContext : IdentityDbContext<AppUser,IdentityRole<int>, int>
    {
        public SSDbContext(DbContextOptions<SSDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //admin User Add

            string admin = "Admin";
            string mail = admin + "@mail.com";

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>()
                   .HasData(new AppUser
                   {
                       Id = 1,
                       Name = admin,
                       Surname = admin,
                       UserName = admin,
                       NormalizedUserName = admin.ToUpper(),
                       Email = mail,
                       NormalizedEmail = mail.ToUpper(),
                       BirthDate = new DateOnly(1999,1,1),
                       Gender = COMMON.Gender.Male,
                       EmailConfirmed = true,
                       PhoneNumberConfirmed = true,
                       PhoneNumber = "-",
                       PasswordHash = hasher.HashPassword(null, "Ece*1998")

                   });

            //admin Role Add

            builder.Entity<IdentityRole<int>>()
                   .HasData(new IdentityRole<int>
                   {
                       Id = 1,
                       Name = admin,
                       NormalizedName = admin.ToUpper()
                   });

            //admin to Role Add

            builder.Entity<IdentityUserRole<int>>()
                   .HasData(new IdentityUserRole<int>
                   {
                       UserId = 1,
                       RoleId =1,
                   });
                

        }
    }
}
