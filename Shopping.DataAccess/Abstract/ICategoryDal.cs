
using Shopping.Core.DataAccess;
using Shopping.Entities.Concrete;

namespace Shopping.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}