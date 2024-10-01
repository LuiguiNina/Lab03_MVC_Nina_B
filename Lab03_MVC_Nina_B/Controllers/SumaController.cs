using Lab03_MVC_Nina_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_MVC_Nina_B.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularSuma()
        {
            //Instanciando la clase
            ClsSuma objSuma = new ClsSuma();

            //Obteniendo los parametros del formulario HTML
            objSuma.valor1 = Convert.ToDouble(Request.Form["numero1"]);
            objSuma.valor2 = Convert.ToDouble(Request.Form["numero2"]);

            //Calculo de la operacion
            objSuma.resultado = objSuma.valor1 + objSuma.valor2;

            return View();
            
        }
    }
}