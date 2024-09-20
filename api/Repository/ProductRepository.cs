using Microsoft.AspNetCore.Mvc;
using api.Models;
namespace api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private Mydb db;
        public ProductRepository(Mydb db)
        {
            this.db = db;
        }
        public void Add(Product obj)
        {
            db.Add(obj);
        }
        public void Update(Product obj)
        {
            db.Update(obj);
        }
        public void Delete(int id)
        {
            Product product = this.Getbyid(id);
            db.products.Remove(product);
        }

        public List<Product> GetAll()
        {
            return db.products.ToList();
        }

        public Product Getbyid(int id)
        {
            return db.products.SingleOrDefault(c => c.Id == id);
        }
        public void Save()
        {
            db.SaveChanges();
        }



    }
}
