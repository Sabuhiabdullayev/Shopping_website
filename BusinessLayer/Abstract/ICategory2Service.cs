using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategory2Service:IGenericService<Category2>
    {
        List<Product> GetListByFilter(int id);
    }
}
