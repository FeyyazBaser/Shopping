using Shopping.Core.DataAccess.EntityFramework;
using Shopping.Entities.Concrete;
using Shopping.DataAccess.Abstract;

namespace Shopping.DataAccess.Concrete.EntityFramework
{
    public class ProductDal:BaseRepository<Product,ShoppingContext>,IProductDal
    {

    }
}
