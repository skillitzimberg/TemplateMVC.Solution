using Microsoft.AspNetCore.Mvc;
using TemplateMVC.Models;

namespace TemplateMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("/index")]
        public ActionResult Index() { return View(); }

    }
}
