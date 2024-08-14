using Catelog.API.Manager;
using Catelog.API.Models;

namespace Catelog.API.Context
{
    public class CatalogDbContextSeed
    {
        static ProductManager _productManager = new ProductManager();
        public static void Seed()
        {
            var product= _productManager.GetFirstOrDefault(x => true);
            if (product != null)
            {
                _productManager.Add(GetPreConfiguredProduct());
            }
        }

        private static List<Product> GetPreConfiguredProduct()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Wireless Mouse",
                    Summery = "Ergonomic wireless mouse with high precision.",
                    Description = "This wireless mouse features an ergonomic design, making it comfortable for long hours of use. It offers high precision with adjustable DPI settings and a long-lasting battery life.",
                    ImageFile = "wireless_mouse.jpg",
                    Price = 29.99m,
                    Category = "Electronics"
                },
                new Product
                {
                    Id = 2,
                    Name = "Bluetooth Headphones",
                    Summery = "Noise-cancelling Bluetooth headphones with superior sound quality.",
                    Description = "Experience high-fidelity audio with these Bluetooth headphones. Equipped with active noise-cancelling technology, they provide a superior listening experience with comfortable over-ear cushions and long battery life.",
                    ImageFile = "bluetooth_headphones.jpg",
                    Price = 89.99m,
                    Category = "Electronics"
                },
                new Product
                {
                    Id = 3,
                    Name = "Yoga Mat",
                    Summery = "Non-slip yoga mat for a comfortable workout.",
                    Description = "This high-quality yoga mat provides excellent grip and cushioning. Ideal for various types of workouts, it’s designed to be non-slip and durable, ensuring a stable and comfortable exercise experience.",
                    ImageFile = "yoga_mat.jpg",
                    Price = 19.99m,
                    Category = "Fitness"
                },
                new Product
                {
                    Id = 4,
                    Name = "Blender",
                    Summery = "High-speed blender for smooth and efficient blending.",
                    Description = "This powerful blender features multiple speed settings and a robust motor, perfect for making smoothies, soups, and sauces. The easy-to-clean design and durable construction make it a versatile kitchen appliance.",
                    ImageFile = "blender.jpg",
                    Price = 59.99m,
                    Category = "Kitchen"
                },
                new Product
                {
                    Id = 5,
                    Name = "LED Desk Lamp",
                    Summery = "Adjustable LED desk lamp with touch control.",
                    Description = "Brighten up your workspace with this modern LED desk lamp. It features adjustable brightness levels, a flexible neck, and touch controls for easy operation. The sleek design fits well in any office or study area.",
                    ImageFile = "led_desk_lamp.jpg",
                    Price = 39.99m,
                    Category = "Home"
                }
            };
        }
    }
}
