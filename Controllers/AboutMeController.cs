using System;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_Dilemma98.Controllers;

public class AboutMeController : Controller
{
     public IActionResult Index()
    {
        ViewBag.message="Om mig";
        return View();
    }
}
