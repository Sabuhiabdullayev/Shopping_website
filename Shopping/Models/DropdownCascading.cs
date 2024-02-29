using System.Web.Mvc;

namespace Shopping.Models
{
    public class DropdownCascading
    {
        public IEnumerable<SelectListItem> Catalog { get; set; }
        public IEnumerable<SelectListItem> Category2 { get; set; }
    }
}
