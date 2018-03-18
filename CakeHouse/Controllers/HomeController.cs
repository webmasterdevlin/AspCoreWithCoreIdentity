using CakeHouse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CakeHouse.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CakeHouse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var cakes = _cakeRepository.GetAllCakes().OrderBy(c => c.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Custom Cake Delivery",
                Cakes = cakes.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);
            if (cake == null)
            {
                return NotFound();
            }

            return View(cake);
        }
    }
}