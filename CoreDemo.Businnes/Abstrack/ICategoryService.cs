using CoreDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Businnes.Abstrack
{
   public interface ICategoryService
    {
        List<Category> GetListAll();
        void CategoryAdd(Category category);
        void BCategoryDelete(Category category);
        void CategoryUpdate(Category category);
        Category GetById(int id);
    }
}
