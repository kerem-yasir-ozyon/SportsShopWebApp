using SS.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.ENTITIES.Abstract
{
    public class BaseEntity : IBaseEntity
    {

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        //////////////////////////////////////
        
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        
    }
}
