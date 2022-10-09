﻿using CoreDemo.Businnes.Concrete;
using CoreDemo.DataAccsess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetBlogByWriter(1);
            return View(values);
        }
    }
}
