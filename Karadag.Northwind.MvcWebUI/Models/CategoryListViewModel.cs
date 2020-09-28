using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Karadag.Northwind.Entities.Concrete;

namespace Karadag.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
