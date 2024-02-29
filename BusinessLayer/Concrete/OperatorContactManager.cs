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
    public class OperatorContactManager : IOperatorContactService
    {

        IOperatorContactDal _operatorContactDal;

        public OperatorContactManager(IOperatorContactDal operatorContactDal)
        {
            _operatorContactDal = operatorContactDal;
        }

        public void TAdd(OperatorContact t)
        {
            _operatorContactDal.Insert(t);
        }

        public void TDel(OperatorContact t)
        {
            _operatorContactDal.Delete(t);
        }

        public OperatorContact TGetById(int? id)
        {
           return _operatorContactDal.GetById(id);
        }

        public List<OperatorContact> TGetList()
        {
          return  _operatorContactDal.GetList();
        }

        public List<OperatorContact> TGetMemberIncludeList()
        {
            return _operatorContactDal.GetMemberIncludeList();
        }

       

        public void TUpdate(OperatorContact t)
        {
            _operatorContactDal.Update(t);
        }
    }
}
