using Karadag.Core.DataAccess;
using Karadag.Northwind.Entities.Concrete;

namespace Karadag.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}
