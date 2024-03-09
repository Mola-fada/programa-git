using MOLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOLA.Models.Permiso;
namespace MOLA.Controllers
{
    
    public class HomeController : Controller
    {

        public ActionResult Pagina()
        {
            return View();
        }
        [ValidarSesion]

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult service()
        {
            return View();
        }
        public ActionResult Price()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login", "Acceso");
        }

        public ActionResult Turnos()
        {
            return RedirectToAction("Turnos", "Turnos");
        }
        public ActionResult Empleados()
        {
            return View();
        }

        




    }
}