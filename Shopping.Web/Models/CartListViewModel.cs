using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Entities.Concrete;


namespace Shopping.Web.Models
{
    public class CartListViewModel
    {
        public Cart Cart { get; internal set; }
    }
}
