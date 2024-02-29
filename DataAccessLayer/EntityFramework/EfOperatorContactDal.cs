using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfOperatorContactDal : GenericRepository<OperatorContact>, IOperatorContactDal
    {
        public List<OperatorContact> GetMemberIncludeList()
        {
            using (var c = new Context())
            {
                return c.OperatorContacts.Include(x => x.AppUsers).ToList();
            }
        }
    }
}
