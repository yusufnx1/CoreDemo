using CoreDemo.Businnes.Concrete;
using CoreDemo.DataAccsess.EntityFramework;
using CoreDemo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommetManager Cm = new CommetManager(new EFCommetRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]   
        public PartialViewResult PartialAddCommet()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddCommet(Commet p)
        {
            p.CommetDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommetStatus = true;
            p.BlogId = 2;
            Cm.CommetAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
           
            var values = Cm.GetListAll(id);
            return PartialView(values);
        }
    }
}
