using api.Models;

namespace api.Repository
{
    public interface ICategoryRepository
    {
        public void Add(Category obj);
        public void Update(Category obj);
        public void Delete(int id);

        public List<Category> GetAll();

        public Category Getbyid(int id);
        public void Save();
    }
}
