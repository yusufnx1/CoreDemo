using CoreDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Businnes.Abstrack
{
    public interface ICommetService
    {
        List<Commet> GetListAll(int id);
        void CommetAdd(Commet commet);


       // void CommetDelete(Commet commet);
       // void CommetUpdate(Commet commet);
       // Commet GetById(int id);
    }
}
