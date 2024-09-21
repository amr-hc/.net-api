using api.Models;

namespace api.Repository
{
    public interface IProductRepository
    {
        public void Add(Product obj);
        public void Update(Product obj);
        public void Delete(int id);

        public List<Product> GetAll();

        public Product Getbyid(int id);
        public void Save();
    }
}
