using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.VIEWMODEL.Category
{
    public class CategoryViewModel : BaseViewModel
    {
        public int? Id { get; set; }
        public int? RowNum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AppUserId { get; set; }

    }

    //public class CategoryEditViewModel : CategoryViewModel
    //{
    //    public int Id { get; set; }
    //}

    //public class CategoryListViewModel : CategoryViewModel
    //{
    //    public int RowNum { get; set; }
    //}

    //public class CategoryDetailViewModel : CategoryEditViewModel
    //{
    //    //productList eklenebilir
    //}
}
