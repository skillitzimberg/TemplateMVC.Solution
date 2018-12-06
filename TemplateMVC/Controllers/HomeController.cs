using Microsoft.AspNetCore.Mvc;

namespace TemplateMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
