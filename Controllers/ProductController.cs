using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_Dilemma98.Models;

namespace uppfinnaren_1_0_Dilemma98.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }   
    public IActionResult Index()
    {
        ViewBag.message="Mina alster!";
        return View(_productRepository.AllProducts);
    }

    public IActionResult Info(int id)
    {
        var product = _productRepository.GetProductById(id);
        return View(product);
    }
}
