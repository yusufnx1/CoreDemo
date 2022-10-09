using CoreDemo.Businnes.Concrete;
using CoreDemo.DataAccsess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Categories
{
    public class CategoryList:ViewComponent
    {
        CategoryManager Cm =new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = Cm.GetListAll();
            return View(values);
        }
    }
}
