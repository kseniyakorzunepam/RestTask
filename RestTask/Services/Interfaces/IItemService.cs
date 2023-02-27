using Microsoft.AspNetCore.Mvc;
using RestTask.DTO;

namespace RestTask.Services.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItemsByCategoryId(int categoryId);
        Task<IActionResult> AddItem(Item item);
        Task<IActionResult> UpdateItem(Item item);
        Task<IActionResult> DeleteItem(int id);
    }
}
