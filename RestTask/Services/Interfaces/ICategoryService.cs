using Microsoft.AspNetCore.Mvc;
using RestTask.DTO;

namespace RestTask.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<IActionResult> AddCategory(Category category);        
        Task<IActionResult> UpdateCategory(Category category);       
        Task<IActionResult> DeleteCategory(int id);
    }
}
