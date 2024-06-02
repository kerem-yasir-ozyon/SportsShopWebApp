using SS.DAL.DataContext;
using SS.DAL.Repository.Abstract;
using SS.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.DAL.Repository.Concrete
{
    public class CategoryRepo : Repo<Category>
    {
        public CategoryRepo(SSDbContext dbContext) : base(dbContext)
        {
        }
    }
}
