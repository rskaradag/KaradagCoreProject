using Karadag.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karadag.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
