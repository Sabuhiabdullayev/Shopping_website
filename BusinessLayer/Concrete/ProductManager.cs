using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
    private readonly  IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetListByFilter(int id)
        {
            return _productDal.GetByListFilter(x => x.AppUserId == id);
        }

        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDel(Product t)
        {
            _productDal.Delete(t);
        }

       

        public Product TGetById(int? id)
        {
            return _productDal.GetById(id);
        }

       

        public List<Product> TGetIncludeListProducts()
		{
            return _productDal.GetIncludeListProducts();
		}

		public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

       

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public List<Product> T_PremiumExpectedProducts()
        {
            return _productDal.GetByListFilter(x => x.Premium == "Gözlənilir");
        }

        public List<Product> T_PremiumUnapprovedProducts()
        {
            return _productDal.GetByListFilter(x => x.Premium == "Təstiqlənməyib");
        }

        public List<Product> T_PremiumVerifiedProducts()
        {
            return _productDal.GetByListFilter(x => x.Premium == "Təsdiqləndi");
        }

        public List<Product> T_VipExpectedProducts()
        {
            return _productDal.GetByListFilter(x => x.Vip == "Gözlənilir");
        }

        public List<Product> T_VipUnapprovedProducts()
        {
            return _productDal.GetByListFilter(x => x.Vip == "Təstiqlənməyib");
        }

        public List<Product> T_VipVerifiedProducts()
        {
            return _productDal.GetByListFilter(x => x.Vip == "Təsdiqləndi");
        }
    }
}
