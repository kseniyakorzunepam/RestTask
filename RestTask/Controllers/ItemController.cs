using Microsoft.AspNetCore.Mvc;
using RestTask.DTO;
using RestTask.Services.Interfaces;

namespace RestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemsByCategoryId(int categoryId)
        {
            var items = await _itemService.GetItemsByCategoryId(categoryId);
            return new OkObjectResult(items);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem([FromBody] Item item)
        {
            return await _itemService.AddItem(item);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateItem([FromBody] Item item)
        {
            return await _itemService.UpdateItem(item);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteItem(int id)
        {
            return await _itemService.DeleteItem(id);
        }
    }
}
