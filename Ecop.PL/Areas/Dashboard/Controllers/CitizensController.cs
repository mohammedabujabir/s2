using Microsoft.AspNetCore.Mvc;

namespace Ecop.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CitizensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
