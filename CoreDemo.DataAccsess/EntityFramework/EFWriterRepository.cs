﻿using CoreDemo.DataAccsess.Abstrack;
using CoreDemo.DataAccsess.Repositories;
using CoreDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccsess.EntityFramework
{
    public class EFWriterRepository:GenericRepository<Writer>,IWriterDal
    {
    }
}
