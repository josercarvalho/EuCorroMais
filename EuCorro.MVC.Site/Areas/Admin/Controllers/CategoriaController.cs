using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EuCorro.App.Interface;
using Eucorro.Domain.Models;
using PagedList;
using EuCorro.Security.Filters;

namespace EuCorro.MVC.Site.Areas.Admin.Controllers
{
    [ClaimsAuthorize("Admin", "True")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaApp _categoria;

        public CategoriaController(ICategoriaApp categoria)
        {
            _categoria = categoria;
        }

        // GET: Admin/Categoria
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var categorias = _categoria.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                categorias = categorias.Where(s => s.Nome.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "Nome_desc":
                    categorias = categorias.OrderByDescending(s => s.Nome);
                    break;
                //case "Data":
                //    fornecedores = fornecedores.OrderBy(s => s.Email);
                //    break;
                //case "Data_desc":
                //    fornecedores = fornecedores.OrderByDescending(s => s.Email);
                //    break;
                default:
                    categorias = categorias.OrderBy(s => s.Nome);
                    break;
            }

            const int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(categorias.ToPagedList(pageNumber, pageSize));
        }

        // GET: Admin/Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria model)
        {
            if (ModelState.IsValid)
            {
                _categoria.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Admin/Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = _categoria.GetById(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        // POST: Admin/Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _categoria.Update(categoria);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(categoria);
            }
        }

        // POST: Admin/Categoria/Delete/5
        [HttpPost]
        public JsonResult DeleteCategoria(int id)
        {
            string mensagemErro = "Excluído com sucesso...";
            try
            {
                Categoria categoria = _categoria.GetById(id);
                _categoria.Remove(categoria);
            }
            catch (Exception ex)
            {
                mensagemErro = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return Json(mensagemErro, JsonRequestBehavior.DenyGet);
        }
    }
}