using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RazorExample.Models;

namespace RazorExample.Controllers
{
  public class HomeController : Controller
  {
    Product myProduct = new Product
    {
      ProductID = 1,
      Name = "Kayak",
      Description = "A boat for one person",
      Category = "Watersport",
      Price = 275M
    };

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View(myProduct);
    }

    public IActionResult NameAndPrice() => View(myProduct);

    public IActionResult DemoExpression()
    {
      ViewBag.ProductCount = 1;
      ViewBag.ExpressShip = true;
      ViewBag.ApplyDiscount = false;
      ViewBag.Supplier = null;
      return View(myProduct);
    }

    public IActionResult DemoArray()
    {
      Product[] array = 
      {
        new Product {Name = "Kayak", Price = 275m },
        new Product {Name = "LifeJacket", Price = 48.95m },
        new Product {Name = "Soccer ball", Price = 19.5m },
        new Product {Name = "Corner flag", Price = 34.95m },
      };
      return View(array);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
