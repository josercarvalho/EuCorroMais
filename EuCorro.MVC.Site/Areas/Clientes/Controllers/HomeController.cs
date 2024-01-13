using EuCorro.MVC.Site.Aolication.MvcExtensions;
using System.Web.Mvc;

namespace EuCorro.MVC.Site.Areas.Clientes.Controllers
{
    [ClienteAuth]
    public class HomeController : Controller
    {
        // GET: Clientes/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}