using Microsoft.AspNetCore.Mvc;
using RestTask.DTO;
using RestTask.Services.Interfaces;

namespace RestTask.Services.Implementation
{
    public class ItemService : IItemService
    {
        public async Task<IEnumerable<Item>> GetItemsByCategoryId(int categoryId)
        {
            return Catalog.Items.Where(x => x.CategoryId == categoryId).ToList();
        }

        public async Task<IActionResult> AddItem(Item item)
        {
            Catalog.Items.Add(item);
            return new OkResult();
        }

        public async Task<IActionResult> UpdateItem(Item item)
        {
            var oldItem = Catalog.Items.FirstOrDefault(x => x.Id.Equals(item.Id));
            if (oldItem != null)
            {
                var category = Catalog.Categories.FirstOrDefault(x => x.Id.Equals(item.CategoryId));
                if (category != null)
                {
                    oldItem.Name = item.Name;
                    oldItem.CategoryId = item.CategoryId;
                    return new OkResult();
                }
                else return new NotFoundObjectResult($"Category with ID {item.CategoryId} does not exist");
            }
            return new NotFoundObjectResult($"Item with ID {item.Id} does not exist.");
        }

        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = Catalog.Items.FirstOrDefault(x => x.Id.Equals(id));
            if (item != null)
            {
                Catalog.Items.Remove(item);
                return new OkResult();
            }
            return new NotFoundResult();
        }
    }
}
