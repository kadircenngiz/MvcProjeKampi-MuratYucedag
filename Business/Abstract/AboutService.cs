using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface AboutService
    {
        List<About> GetList();
        void AboutAdd(About about);
        void AboutDelete(About about);
        void AboutUpdate(About about);
        About GetById(int id);
    }
}
