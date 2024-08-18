using Microsoft.AspNetCore.Mvc;
using MVCTesting.Models;

namespace MVCTesting.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Sif",
                Age = 2,
            };
            return View(doggo);
        }
        public IActionResult Page1()
        {
            return View();
        }
    }
}
