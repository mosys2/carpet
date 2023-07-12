using Microsoft.AspNetCore.Mvc;

namespace EndPointStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
