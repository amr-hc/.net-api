using Microsoft.AspNetCore.Mvc;
using api.Models;
using Microsoft.EntityFrameworkCore;
namespace api.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private Mydb db;
        public CategoryRepository(Mydb db)
        {
            this.db = db;
        }
        public void Add(Category obj)
        {
            db.Add(obj);
        }
        public void Update(Category obj)
        {
            db.Update(obj);
        }
        public void Delete(int id)
        {
            Category category = this.Getbyid(id);
            db.Category.Remove(category);
        }

        public List<Category> GetAll()
        {
            return db.Category.ToList();
        }

        public Category Getbyid(int id)
        {
            return db.Category.Include(c=>c.Products)
                .SingleOrDefault(c => c.Id == id);
        }
        public void Save()
        {
            db.SaveChanges();
        }



    }
}
