namespace RestTask.DTO
{
    public static class Catalog
    {
        public static List<Category> Categories { get; set; } = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Clothes"
            },
            new Category
            {
                Id = 2,
                Name = "Shoes"
            },
            new Category
            {
                Id = 3,
                Name = "Accessories"
            }
        };

        public static List<Item> Items { get; set; } = new List<Item> 
        {
            new Item
            {
                Id = 1,
                CategoryId = 1,
                Name = "Black dress"
            },
            new Item
            {
                Id = 2,
                CategoryId = 1,
                Name = "White blouse"
            },
            new Item
            {
                Id = 3,
                CategoryId = 2,
                Name = "Brown boots"
            },
            new Item
            {
                Id = 4,
                CategoryId = 3,
                Name = "Golden ring"
            }
        };
    }
}
