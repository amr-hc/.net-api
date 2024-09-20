using api.Models;
using api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private IProductRepository productRepo;


        public ProductController(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        [HttpGet("{name}")]
        public IActionResult Getall(string name)
        {
            return Ok(name);
            //return Ok(productRepo.GetAll().ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Getbyid(int id)
        {
            return Ok(productRepo.Getbyid(id));
        }

        [HttpPost]
        public IActionResult add(Product product)
        {
            productRepo.Add(product);
            productRepo.Save();
            return Ok();
        }


        [HttpPut]
        [Route("{id:int}")]
        public IActionResult update(int id,Product product)
        {
            product.Id = id;
            productRepo.Update(product);
            productRepo.Save();
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult delete(int id)
        {
            productRepo.Delete(id);
            productRepo.Save();
            return Ok();
        }
    }
}
