using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerpetuumSoft.Knockout;
using Knockout002.Models;

namespace Knockout002.Controllers
{
    public class SaludaController : KnockoutController
    {
        // GET: Saluda
        public ActionResult Index()
        {
            ViewBag.Title = "Hola Mundo";
            return View(new Persona
            {
                Nombre = "Steve",
                Apellido = "Sanderson"
            });
        }
    }
}