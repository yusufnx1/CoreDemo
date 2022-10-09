using CoreDemo.Businnes.Abstrack;
using CoreDemo.DataAccsess.Abstrack;
using CoreDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Businnes.Concrete
{
    public class CommetManager : ICommetService
    {
        ICommetDal _commetDal;

        public CommetManager(ICommetDal commetDal)
        {
            _commetDal = commetDal;
        }

        public void CommetAdd(Commet commet)
        {
            _commetDal.Insert(commet);
        }

        public List<Commet> GetListAll(int id)
        {
            return _commetDal.GetListAll(x => x.BlogId == id);
        }
    }
}
