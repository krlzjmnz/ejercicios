using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    
    public class HomeController : Controller {
      static List<Product> listProducts = new List<Product>();
        public ActionResult Index(){
            return View();
        }
        public ActionResult Agregar(Product producto){
            listProducts.Add(producto);
            return View("Index",producto);
        }
        public ActionResult MostrarTodo(){
            return View("ShowAll",listProducts);
        }

        [HttpGet]
        public JsonResult MostrarAsincrono(){
            return Json("algo");
        }
    }
}