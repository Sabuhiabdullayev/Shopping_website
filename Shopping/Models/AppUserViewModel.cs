

using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class AppUserViewModel
    {

        [Required(ErrorMessage ="UserName Error")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Name Error")]
        public string Name { get; set; }

        [Required(ErrorMessage = "SurName Error")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Email Error")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gender Error")]
        public string Genger { get; set; }
        public string Phone { get; set; }
        public IFormFile ImageSmall { get; set; }
        public IFormFile ImageBig { get; set; }

        [Required(ErrorMessage = "Password Error")]
        public string Password { get; set; }
        public string ConfigPassword { get; set; }
    }
}
