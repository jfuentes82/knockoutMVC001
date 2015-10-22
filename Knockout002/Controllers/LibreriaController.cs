using Knockout002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout002.Controllers
{
    public class LibreriaController : Controller
    {
        private static readonly Libreria Library = new Libreria();
        // GET: Libreria
        public ActionResult Index()
        {
            return View(Library);
        }

        public JsonResult GetName()
        {
            return Json(Library.Name, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBooks()
        {
            return Json(Library.GetBooks(),
              JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(Library.GetBook(id));
        }
        [HttpPost]
        public ActionResult Edit(Libro book)
        {
            Library.UpdateBook(book);
            return RedirectToAction("Index");
        }
        public JsonResult Add()
        {
            var book = new Libro
            {

                Titulo = "New book",
                Autor = "Unknown",
                Año = DateTime.Now.Year
            };
            Library.AddBook(book);
            return Json(Library.GetBooks(),
              JsonRequestBehavior.AllowGet);
        }
        public JsonResult Remove(int id)
        {
            Library.RemoveBook(id);
            return Json(Library.GetBooks(),
              JsonRequestBehavior.AllowGet);
        }
    }
}
