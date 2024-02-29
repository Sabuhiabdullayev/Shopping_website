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
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public List<Notification> GetFilterListNotification(int id)
        {
            using (var context = new Context())
            {
                return context.Notifications.Include(y=>y.AppUser).Where(x => x.MemberId == id || x.MemberId == 0).ToList();

            }

        }
    }
}
