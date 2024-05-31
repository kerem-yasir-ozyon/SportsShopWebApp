using Microsoft.AspNetCore.Identity;
using SS.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.ENTITIES.Concrete
{
    public class AppUser :IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDay { get; set; }
        public Gender Gender { get; set; }
    }
}
