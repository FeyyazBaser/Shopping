using System.Collections.Generic;
using Shopping.Entities.Concrete;

namespace Shopping.Web.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}