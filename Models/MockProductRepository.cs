using System;

namespace uppfinnaren_1_0_Dilemma98.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> AllProducts =>
    new List<Product>
    {
        new Product { ProductId = 1, Name = "Familjepussel", Price = 350 },
        new Product { ProductId = 2, Name = "Leksakspaket", Price = 750 },
        new Product { ProductId = 3, Name = "Köksslevar", Price = 100 },
        new Product { ProductId = 4, Name = "Skogsvarelser", Price = 150 }
    };
    public Product? GetProductById(int productId) => AllProducts.FirstOrDefault(p => p.ProductId == productId);
}
