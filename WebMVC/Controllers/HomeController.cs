using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        ProductosBL _bl = new ProductosBL();
        public ActionResult Index()
        {
           ViewBag.ListaProductos = _bl.ConsultarProd().ToList();
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(ProductosEN pEN)
        {
            _bl.AgregarProducto(pEN); // se pasan los parametros.
            return RedirectToAction("Index");
        }
    }
}