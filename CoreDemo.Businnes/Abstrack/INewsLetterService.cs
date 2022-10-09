using CoreDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Businnes.Abstrack
{
    public interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsLetter);
    }
}
