using CoreDemo.Businnes.Concrete;
using CoreDemo.DataAccsess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommetManager Cm = new CommetManager(new EFCommetRepository());
        public IViewComponentResult Invoke(int id)
        {
            var valus = Cm.GetListAll(id);
            return View(valus);
        }
    }
}
