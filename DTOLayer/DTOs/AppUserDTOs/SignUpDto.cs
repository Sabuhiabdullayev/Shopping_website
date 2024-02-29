using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOLayer.DTOs.AppUserDTOs
{
    public class SignUpDto
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Email { get; set; }

        public string Genger { get; set; }
        public string Phone { get; set; }
        public FormFile ImageSmall { get; set; }
        public FormFile ImageBig { get; set; }

        public string Password { get; set; }
        public string ConfigPassword { get; set; }
    }
}
