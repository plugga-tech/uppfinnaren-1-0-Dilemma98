using System;

namespace uppfinnaren_1_0_Dilemma98.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> AllProducts =>
    new List<Product>
    {
        new Product { ProductId = 1, Name = "Familjepussel", Price = 350, Description = "En liten pusseltavla av dig och din familj. Görs på beställning utefter önskemål." },
        new Product { ProductId = 2, Name = "Leksakspaket", Price = 750, Description = "Ett paket med två elefanter, en regnbåge i delar, två fåglar, två kaniner och två träd." },
        new Product { ProductId = 3, Name = "Köksslevar", Price = 200, Description = "Paket med tre slevar i olika storlekar." },
        new Product { ProductId = 4, Name = "Skogsvarelser", Price = 150, Description = "Två söta skogsvarelser." }
    };
    public Product? GetProductById(int productId) => AllProducts.FirstOrDefault(p => p.ProductId == productId);
}
