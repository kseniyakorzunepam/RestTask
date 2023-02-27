using Moq;
using RestTask.Services.Interfaces;

namespace RestTaskTests
{
    public class CategoryTests
    {
        private ICategoryService _categoryService;

        public CategoryTests()
        {
            
        }

        [Fact]
        public void TestGetCategories_Success()
        {
            var categoryServiceMock = new Mock<ICategoryService>();
            //categoryServiceMock.Setup()
        }
    }
}