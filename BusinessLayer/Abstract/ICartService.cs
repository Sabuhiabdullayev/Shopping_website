﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartService:IGenericService<Cart>
    {
        List<Cart> TGetIncludeList();
        List<Cart> GetListByFilter(int id);
    }
}
