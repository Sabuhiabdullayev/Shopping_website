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
    
    public class ProductCommentManager:IProductCommentService
    {
        IProductCommentDal _commentDal;

        public ProductCommentManager(IProductCommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(ProductComment t)
        {
            _commentDal.Insert(t);
        }

        public void TDel(ProductComment t)
        {
            _commentDal.Delete(t);        }

        public ProductComment TGetById(int? id)
        {
          return  _commentDal.GetById(id);
        }

        public List<ProductComment> TGetCommentlistById(int id)
        {
          return  _commentDal.GetByListFilter(x=>x.ProductId==id);
        }

        public List<ProductComment> TGetList()
        {
            return _commentDal.GetList();
        }

        public void TUpdate(ProductComment t)
        {
            _commentDal.Update(t);
        }
    }
}
