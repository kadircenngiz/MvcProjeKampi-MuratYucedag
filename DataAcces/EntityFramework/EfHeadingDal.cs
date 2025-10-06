using DataAcces.Abstract;
using DataAcces.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.EntityFramework
{
    public class EfHeadingDal:GenericRepository<Heading>,IHeadingDal
    {
    }
}
