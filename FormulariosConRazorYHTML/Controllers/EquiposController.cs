using Microsoft.AspNetCore.Mvc;

namespace FormulariosConRazorYHTML.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
