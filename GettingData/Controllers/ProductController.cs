using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Id=1, ProductName="kitap"},
            new Product(){Id=2, ProductName="defter"},
            new Product(){Id=3, ProductName="kalem"},
            new Product(){Id=4, ProductName="silgi"}
        };

        public IActionResult GetAllProducts()
        {
            return View(products);
        }
        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.Id == id);
            if (product == null)
            {
                ViewBag.Error = "Verilen id ile bir ürün bulunamadı.";
            }
            return View(product);
        }
    }
}
