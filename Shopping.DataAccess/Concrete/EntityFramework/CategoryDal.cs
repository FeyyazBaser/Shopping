using Shopping.Core.DataAccess.EntityFramework;
using Shopping.DataAccess.Abstract;
using Shopping.Entities.Concrete;
using Shopping.DataAccess.Concrete.EntityFramework;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class CategoryDal : BaseRepository<Category, ShoppingContext>, ICategoryDal
    {

    }
}