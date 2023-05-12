using System;
using System.Threading.Tasks;

namespace Shopping.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
