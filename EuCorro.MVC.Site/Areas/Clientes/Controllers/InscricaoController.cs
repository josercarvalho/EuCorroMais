using EuCorro.MVC.Site.Aolication.MvcExtensions;
using System.Web.Mvc;

namespace EuCorro.MVC.Site.Areas.Clientes.Controllers
{
    [ClienteAuth]
    public class InscricaoController : Controller
    {
        // GET: Clientes/Inscricao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clientes/Inscricao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Inscricao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Inscricao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Inscricao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Inscricao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Inscricao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Inscricao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
