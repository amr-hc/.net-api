using api.DTO;
using api.Models;
using api.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository categoryRepo;
        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        [Authorize]
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Getbyid(int id)
        {
            Category category = categoryRepo.Getbyid(id);
            GetCategory getCategory = new GetCategory();
            getCategory.Id = category.Id;
            getCategory.Name = category.Name;
            getCategory.products = category.Products.Select(c=>c.name).ToList();
            return Ok(getCategory);
        }



    }


    ;



}
