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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }
        public List<Cart> GetListByFilter(int id)
        {
            return _cartDal.GetByListFilter(x => x.AppUserId == id);
        }
        public void TAdd(Cart t)
        {
            _cartDal.Insert(t);
        }

        public void TDel(Cart t)
        {
            _cartDal.Delete(t);
        }

        public Cart TGetById(int? id)
        {
          return  _cartDal.GetById(id);
        }

        public List<Cart> TGetIncludeList()
        {
            return _cartDal.GetIncludeList();
        }

        public List<Cart> TGetList()
        {
            return _cartDal.GetList();
        }

        public void TUpdate(Cart t)
        {
            _cartDal.Update(t);
        }
    }
}
