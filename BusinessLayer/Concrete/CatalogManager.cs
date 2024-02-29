using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CatalogManager : ICatalogService
    {
        ICatalogDal _catalogDal;

        public CatalogManager(ICatalogDal catalogDal)
        {
            _catalogDal = catalogDal;
        }

        public void TAdd(Catalog t)
        {
            _catalogDal.Insert(t);
        }

        public void TDel(Catalog t)
        {
            _catalogDal.Delete(t);        }

        public Catalog TGetById(int? id)
        {
          return  _catalogDal.GetById(id);
        }

        public List<Catalog> TGetList()
        {
            return _catalogDal.GetList();
        }

        public void TUpdate(Catalog t)
        {
            _catalogDal.Update(t);        }
    }
}
