using E_Shop.Models;

namespace E_Shop
{
    public class StubData
    {
        public List<Product> products { get; set; }
        public StubData()
        {
            products = populateProducts();

        }

        private List<Product> populateProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    //Id = 1,
                    Name = "Wool Fedora Hat",
                    Description = "Stay stylish and warm with our wool " +
                    "fedora hat. Made from high-quality wool, this classic" +
                    " hat features a black band for added elegance.",
                    Price = 39.99,
                    ImageUrl = "https://www.bon-clic-bon-genre.us/photo/px1844-noir-1_20221026111212.jpg",
                    Stock = 4,
                    Material = "Wool",
                    Color = "Black",
                    Brand = "Brixton"
                },
                new Product()
                {
                    //Id = 2,
                    Name = "Cotton Baseball Cap",
                    Description = "Perfect for a casual day out, our cotton baseball cap is a versatile addition to your wardrobe. Made from breathable cotton, this cap features" +
                    " an adjustable strap for a comfortable fit.",
                    Price = 19.99,
                    ImageUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/61YnPjSUf0L._AC_UY1000_.jpg",
                    Stock = 10,
                    Material = "Cotton",
                    Color = "Blue",
                    Brand = "Nike"
                },
                    new Product()
                {
                    //Id = 3,
                    Name = "Leather Aviator Hat",
                    Description = "Stay cozy and fashionable with our leather aviator hat. Made from genuine leather, this hat features a soft and " +
                    "warm lining to keep you comfortable in cold weather.",
                    Price = 79.99,
                    ImageUrl = "https://www.delmonicohatter.com/Merchant2/graphics/00000001/96420409-Aviator-Hats-Bomber-Hats-Brown.jpg",
                    Stock = 3,
                    Material = "Leather",
                    Color = "Brown",
                    Brand = "Canada Goose"
                },
                    new Product()
                {
                    //Id = 4,
                    Name = "Straw Sun Hat",
                    Description = "Stay cool and protected from the sun with our straw sun hat. Made from natural straw, this hat features a wide brim " +
                    "for added coverage and a braided band for added style.",
                    Price = 29.99,
                    ImageUrl = "https://cdn.shopify.com/s/files/1/1643/5313/products/straw-hat-beach-hats-brays-beach-sun-hat-natural-small-medium-28360098742357_1200x.jpg?v=1628344137",
                    Stock = 6,
                    Material = "Straw",
                    Color = "Creamy",
                    Brand = "J.Crew"
                },
                    new Product()
                {
                    //Id = 5,
                    Name = "Straw Sun Hat 2022",
                    Description = "Stay cool and protected from the sun with our straw sun hat.",
                    Price = 29.99,
                    ImageUrl = "https://cdn.shopify.com/s/files/1/1643/5313/products/straw-hat-beach-hats-brays-beach-sun-hat-natural-small-medium-28360098742357_1200x.jpg?v=1628344137",
                    Stock = 6,
                    Material = "Straw",
                    Color = "Red",
                    Brand = "J.Crew"
                }
            };
        }
    }
}
