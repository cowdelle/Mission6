using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
       public IActionResult FillOutForm()
        {
            return View("FillOutForm");
        }

        [HttpPost]
        public IActionResult FillOutForm(Application response)
        {
            return View("Confirmation");
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Movie()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
