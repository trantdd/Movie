using Microsoft.AspNetCore.Mvc;

namespace movie.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
