using Microsoft.AspNetCore.Mvc;
using RestTask.DTO;
using RestTask.Services.Interfaces;

namespace RestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoriesList()
        {
            var categories = await _categoryService.GetCategories();
            return new OkObjectResult(categories);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] Category category)
        {
            return await _categoryService.AddCategory(category);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] Category category)
        {
            return await _categoryService.UpdateCategory(category);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory([FromBody] int id)
        {
            return await _categoryService.DeleteCategory(id);
        }
    }
}
