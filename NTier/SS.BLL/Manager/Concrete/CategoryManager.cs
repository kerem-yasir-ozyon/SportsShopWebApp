using SS.BLL.Manager.Abstract;
using SS.BLL.Managers.Abstract;
using SS.DAL.Services.Abstract;
using SS.DAL.Services.Concrete;
using SS.DTO;
using SS.ENTITIES.Concrete;
using SS.VIEWMODEL.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.BLL.Manager.Concrete
{
    public class CategoryManager : Manager<CategoryDto, CategoryViewModel, Category>
    {
        public CategoryManager(CategoryService service) : base(service)
        {
        }
        //public int UserId
        //{
        //    set { base.AppUserId = value; }
        //}
    }
}
