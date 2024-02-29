﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
