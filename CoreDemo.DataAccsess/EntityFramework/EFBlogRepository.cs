using CoreDemo.DataAccsess.Abstrack;
using CoreDemo.DataAccsess.Concrete;
using CoreDemo.DataAccsess.Repositories;
using CoreDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccsess.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c=new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }   
        }
    }
}
