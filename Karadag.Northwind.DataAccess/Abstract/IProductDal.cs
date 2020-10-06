using Karadag.Core.DataAccess;
using Karadag.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karadag.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
