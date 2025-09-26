using DataAcces.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo= new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
                //hata mesajı
                Console.WriteLine("Kategori adı boş geçilemez, 3 karakterden az ve 51 karakterden fazla olamaz.");
            }
            else
            {
                repo.Insert(p);
            }
        }

    }
}
