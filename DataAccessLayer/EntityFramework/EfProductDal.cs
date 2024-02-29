using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
       
        public List<Product> GetIncludeListProducts()
		{
            using(var c= new Context())
			{
                return c.Products.Include(x => x.AppUser).OrderByDescending(y=>y.ProductId).ToList();
            }
		}

       
    }
}
