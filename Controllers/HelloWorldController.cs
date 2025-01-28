using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dog = new DogViewModel
            {
                Name = "Fido",
                Breed = "Golden Retriever",
                Age = 5
            };
            return View(dog);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
