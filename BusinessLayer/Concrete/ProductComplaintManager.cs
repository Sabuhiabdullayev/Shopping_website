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
    public class ProductComplaintManager : IProductComplaintService
    {
        IProductComplaintDal _productComplaintDal;

        public ProductComplaintManager(IProductComplaintDal productComplaintDal)
        {
            _productComplaintDal = productComplaintDal;
        }

        public void TAdd(ProductComplaint t)
        {
            _productComplaintDal.Insert(t);
        }

        public void TDel(ProductComplaint t)
        {
            _productComplaintDal.Delete(t);
        }

        public ProductComplaint TGetById(int? id)
        {
            return _productComplaintDal.GetById(id);
        }

        public List<ProductComplaint> TGetList()
        {
            return _productComplaintDal.GetList();
        }

        public void TUpdate(ProductComplaint t)
        {
            _productComplaintDal.Update(t);
        }
    }
}
