using lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
{
    public class ProductController : Controller
    {
        //gia lap csdl
        public static List<Models.Product> products = new List<Models.Product>()
        {
            new Models.Product {Id = 1, Name = "iphone", Price = "18", Description ="so re lam"},
            new Models.Product {Id = 2, Name = "ss", Price = "20", Description ="bth"},
            new Models.Product {Id = 3, Name = "oppo", Price = "7", Description ="k dang gia cao"},
            new Models.Product {Id = 4, Name = "Honro", Price = "12", Description ="cung duoc ma"},
            new Models.Product {Id = 5, Name = "redmi", Price = "14", Description ="chong nuoc, chong bui"},

        };
        // GET: ProductController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var EditProduct = products.FirstOrDefault(c => c.Id == id);
            if (EditProduct == null)
            {
                return NotFound();
            }
            return View(EditProduct);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
