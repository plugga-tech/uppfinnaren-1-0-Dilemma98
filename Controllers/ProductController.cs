using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_Dilemma98.Models;

namespace uppfinnaren_1_0_Dilemma98.Controllers;

public class ProductController : Controller
{
     private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }

    public IActionResult Info(int id)
    {
        var filteredItems = _context.Products
        .Where(p => p.CategoryId == id)
        .ToList();

        return View(filteredItems);
    }
}
