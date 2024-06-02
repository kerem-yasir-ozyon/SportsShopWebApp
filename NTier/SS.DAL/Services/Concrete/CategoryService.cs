using SS.DAL.Repository.Abstract;
using SS.DAL.Repository.Concrete;
using SS.DAL.Services.Abstract;
using SS.DTO;
using SS.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.DAL.Services.Concrete
{
    public class CategoryService : Service<Category, CategoryDto>
    {
        public CategoryService(CategoryRepo repo) : base(repo)
        {
        }
    }
}
