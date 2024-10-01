using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03_MVC_Nina_B.Models;

namespace Lab03_MVC_Nina_B.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalculaCompra(ClsVentaAleatoria objVenta) 
        { 
            Random random = new Random();

            objVenta.random = random.Next(1, 500);

            return View(objVenta);
        }
    }
}