﻿using System.Web.Mvc;

namespace EuCorro.MVC.Site.Controllers
{
    /// <summary>
    /// This is an example controller using the AdminLTE NuGet package's CSHTML templates, CSS, and JavaScript
    /// You can delete these, or use them as handy references when building your own applications
    /// </summary>
    public class AdminLteController : Controller
    {
        /// <summary>
        /// The home page of the AdminLTE demo dashboard, recreated in this new system
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The color page of the AdminLTE demo, demonstrating the AdminLte.Color enum and supporting methods
        /// </summary>
        /// <returns></returns>
        public ActionResult Colors()
        {
            return View();
        }
    }
}