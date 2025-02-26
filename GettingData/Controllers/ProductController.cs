using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Id=1, ProductName="kitap", CategoryName = "kırtasiye"},
            new Product(){Id=2, ProductName="leptop", CategoryName = "bilgisayar"},
            new Product(){Id=3, ProductName="çanta", CategoryName = "giyim"},
            new Product(){Id=4, ProductName="silgi", CategoryName ="kırtasiye"}
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
        public IActionResult GetProductByCategoryName(string CategoryName)
        {
            var product = products.Where(x => x.CategoryName == CategoryName).ToList();
            if (product == null)
            {
                ViewBag.Error = "Verilen kategori adı ile bir ürün bulunamadı.";
            }
            return View(product);
        }
    }
}
