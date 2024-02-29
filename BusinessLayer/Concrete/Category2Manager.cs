using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Category2Manager : ICategory2Service
    {
        ICategory2Dal _category2Dal;

        public Category2Manager(ICategory2Dal category2Dal)
        {
            _category2Dal = category2Dal;
        }

        public List<Product> GetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Category2 t)
        {
            _category2Dal.Insert(t);
        }

        public void TDel(Category2 t)
        {
            _category2Dal.Delete(t);
        }

        public Category2 TGetById(int? id)
        {
            return _category2Dal.GetById(id);
        }

        public List<Category2> TGetList()
        {
            return _category2Dal.GetList();
        }

        public void TUpdate(Category2 t)
        {
            _category2Dal.Update(t);
        }
    }
}
