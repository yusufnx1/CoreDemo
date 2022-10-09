using CoreDemo.Businnes.Concrete;
using CoreDemo.DataAccsess.EntityFramework;
using CoreDemo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nm.AddNewsLetter(newsLetter);
            return PartialView();
        }
    }
}
