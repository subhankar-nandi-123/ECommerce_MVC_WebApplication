using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Web_Application.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
