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
    public class ProductLikeManager : IProductLikeService
    {
        private readonly IProductLikeDal _productLikeDal;

        public ProductLikeManager(IProductLikeDal productLikeDal)
        {
            _productLikeDal = productLikeDal;
        }

        public void TAdd(ProductLike t)
        {
            _productLikeDal.Insert(t);
        }

        public void TDel(ProductLike t)
        {
            _productLikeDal.Delete(t);
        }

        public ProductLike TGetById(int? id)
        {
            return _productLikeDal.GetById(id);
        }

        public List<ProductLike> TGetList()
        {
            return _productLikeDal.GetList();
        }

        public void TUpdate(ProductLike t)
        {
            _productLikeDal.Update(t);
        }
    }
}
