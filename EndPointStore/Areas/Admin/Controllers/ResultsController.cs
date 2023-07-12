using Microsoft.AspNetCore.Mvc;

namespace EndPointStore.Areas.Admin.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
