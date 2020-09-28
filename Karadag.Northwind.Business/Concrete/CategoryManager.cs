using Karadag.Northwind.Business.Abstract;
using Karadag.Northwind.DataAccess.Abstract;
using Karadag.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karadag.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
