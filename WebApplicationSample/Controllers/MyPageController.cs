using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSample.Controllers
{
    public class MyPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
