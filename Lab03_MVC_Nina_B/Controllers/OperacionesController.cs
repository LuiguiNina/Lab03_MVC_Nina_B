using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03_MVC_Nina_B.Models;

namespace Lab03_MVC_Nina_B.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularOperacion(ClsOperaciones objOperacion) 
        {
            if (objOperacion.tipo == "S") {
                objOperacion.resultado = objOperacion.valor1 + objOperacion.valor2;
            }
            if (objOperacion.tipo == "R")
            {
                objOperacion.resultado = objOperacion.valor1 - objOperacion.valor2;
            }
            if (objOperacion.tipo == "M")
            {
                objOperacion.resultado = objOperacion.valor1 * objOperacion.valor2;
            }
            if (objOperacion.tipo == "D")
            {
                if (objOperacion.valor2 != 0) {
                    objOperacion.resultado = objOperacion.valor1 / objOperacion.valor2;
                }
            }
            return View(objOperacion);
        }
    }
}