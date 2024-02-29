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
    public class ProductViewManager : IProductViewService
    {
        private readonly IProductViewDal _productViewDal;

        public ProductViewManager(IProductViewDal productViewDal)
        {
            _productViewDal = productViewDal;
        }

        public void TAdd(ProductView t)
        {
            _productViewDal.Insert(t);
        }

        public void TDel(ProductView t)
        {
            _productViewDal.Delete(t);
        }

        public ProductView TGetById(int? id)
        {
            return _productViewDal.GetById(id);
        }

        public List<ProductView> TGetList()
        {
            return _productViewDal.GetList();
        }

        public void TUpdate(ProductView t)
        {
            _productViewDal.Update(t);
        }
    }
}
