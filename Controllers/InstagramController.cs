using System.Web.Mvc;

namespace webInstagram_MVC.Controllers
{
    public class InstagramController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            return RedirectToAction("Muro");
        }

        [HttpGet]
        public ActionResult Olvidar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Olvidar(FormCollection formCollection)
        {
            return RedirectToAction("OlvidarCodigo");
        }

        public ActionResult OlvidarCodigo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OlvidarCodigo(FormCollection formCollection)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(FormCollection formCollection)
        {
            return View();
        }

        public ActionResult Muro()
        {
            return View();
        }
    }
}