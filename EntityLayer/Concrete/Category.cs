﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
      

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

      

        public int Category2Id { get; set; }
        public  Category2 Category2 { get; set; }
    }
}
