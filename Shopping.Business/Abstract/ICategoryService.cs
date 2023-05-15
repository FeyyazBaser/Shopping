using System.Collections.Generic;
using Shopping.Entities.Concrete;

namespace Shopping.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}