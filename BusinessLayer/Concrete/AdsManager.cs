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
    public class AdsManager : IAdsService
    {
        IAdsDal _adsDal;

        public AdsManager(IAdsDal adsDal)
        {
            _adsDal = adsDal;
        }

        public void TAdd(Ads t)
        {
            _adsDal.Insert(t);
        }

        public void TDel(Ads t)
        {
            _adsDal.Delete(t);
        }

        public Ads TGetById(int? id)
        {
            return _adsDal.GetById(id);
        }

        public List<Ads> TGetList()
        {
            return _adsDal.GetList();
        }

        public void TUpdate(Ads t)
        {
            _adsDal.Update(t);
        }
    }
}
