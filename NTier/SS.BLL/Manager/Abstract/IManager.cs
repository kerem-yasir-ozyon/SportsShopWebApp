using AutoMapper;
using SS.DTO;
using SS.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.BLL.Manager.Abstract
{
    public interface IManager<TDto, TVievModel>
        where TDto : BaseDto
        where TVievModel : BaseViewModel
    {
        IMapper Mapper { set; }
        int Add(TVievModel viewmodel);
        int Update(TVievModel viewmodel);
        int Delete(TVievModel viewmodel);
        int Delete(int id);
        IEnumerable<TVievModel> GetAll();
        TVievModel? Get(int id);
    }
}
