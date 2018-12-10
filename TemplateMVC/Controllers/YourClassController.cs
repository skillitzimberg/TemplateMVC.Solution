using Microsoft.AspNetCore.Mvc;

namespace TemplateMVC.Controllers
{
    public class YourClassController : Controller
    {
        [HttpGet("/yourclass")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
