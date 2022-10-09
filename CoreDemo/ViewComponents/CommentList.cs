using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    Username="Yusuf"
                },
                 new UserComment
                {
                    Id = 2,
                    Username="Eymen"
                }
            };
            return View(commentvalues);
        }
    }
}
