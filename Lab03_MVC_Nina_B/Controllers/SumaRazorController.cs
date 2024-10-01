using Lab03_MVC_Nina_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_MVC_Nina_B.Controllers
{
    public class SumaRazorController : Controller
    {
        // GET: SumaRazor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularSuma(ClsSuma objSuma)
        {

            //Calculo de la operacion
            objSuma.resultado = objSuma.valor1 + objSuma.valor2;

            return View(objSuma);

        }
    }
}