using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetIncludeListProducts();
        List<Product> GetListByFilter(int id);
        List<Product> T_PremiumExpectedProducts();
        List<Product> T_PremiumUnapprovedProducts();
		List<Product> T_PremiumVerifiedProducts();
        List<Product> T_VipExpectedProducts();
        List<Product> T_VipUnapprovedProducts();
        List<Product> T_VipVerifiedProducts();
       
    }
}
