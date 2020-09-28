using Karadag.Core.DataAccess.EntityFramework;
using Karadag.Northwind.DataAccess.Abstract;
using Karadag.Northwind.Entities.Concrete;

namespace Karadag.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
