using Microsoft.AspNetCore.Mvc;
using RestTask.DTO;
using RestTask.Services.Interfaces;

namespace RestTask.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return Catalog.Categories;
        }

        public async Task<IActionResult> AddCategory(Category category)
        {
            Catalog.Categories.Add(category);
            return new OkResult();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = Catalog.Categories.FirstOrDefault(x => x.Id.Equals(id));
            if (category != null)
            {
                Catalog.Categories.Remove(category);
                var items = Catalog.Items.Where(x => x.CategoryId.Equals(id)).ToList();

                if (items.Count > 0)
                {
                    Catalog.Items = Catalog.Items.Where(x => x.CategoryId != id).Distinct().ToList();
                }
                return new OkResult();
            }

            return new NotFoundObjectResult($"Category with ID {id} does not exist");
        }

        public async Task<IActionResult> UpdateCategory(Category category)
        {
            var oldCategory = Catalog.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (oldCategory != null)
            {
                oldCategory.Name = category.Name;
                return new OkResult();
            }
            return new NotFoundObjectResult($"Category with ID {category.Id} does not exist");
        }
    }
}
