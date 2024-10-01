using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03_MVC_Nina_B.Models;

namespace Lab03_MVC_Nina_B.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GenerarTabla(ClsTabla objTabla) 
        { 
            
            return View(objTabla);
        }
    }
}