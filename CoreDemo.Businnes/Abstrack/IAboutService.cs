using CoreDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Businnes.Abstrack
{
    public interface IAboutService
    {
        List<About> GetListAll();
        void AboutAdd(About about);
        void AboutDelete(About about);
        void AboutUpdate(About about);
        About GetById(int id);
    }
}
