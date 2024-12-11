using System;
using uppfinnaren_1_0_Dilemma98.Controllers;

namespace uppfinnaren_1_0_Dilemma98.Models;

public interface IProductRepository
{
    IEnumerable<Product> AllProducts {get;}
    Product? GetProductById(int productId);
}
