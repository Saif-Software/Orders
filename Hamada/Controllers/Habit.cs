using Microsoft.AspNetCore.Mvc;

namespace Hamada.Controllers
{
    public class Habit : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
