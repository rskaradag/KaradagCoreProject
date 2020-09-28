using Karadag.Core.DataAccess.EntityFramework;
using Karadag.Northwind.DataAccess.Abstract;
using Karadag.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karadag.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
