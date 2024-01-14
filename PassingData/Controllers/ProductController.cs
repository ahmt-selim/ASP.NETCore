using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "abdullah onur";
            return View(userName as Object); // view'e string bir parametre gönderileceği zaman objecte çevrilip gönderilmeli. Aksi halde metodun diğer göreviyle karışabilir.
        }
        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.UrunName = "Televizyon";
            product.UnitPrice = 5000;
            return View(product); //View'a sadece bir veri tipi gödnerilebilir.
        }
        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){UrunName ="Bilgisayar", CategoryName="Elektronik", UnitPrice=7000},
                new Product(){UrunName ="Telefon", CategoryName="Elektronik", UnitPrice=3000},
                new Product(){UrunName ="Buzdolabı", CategoryName="Beyaz Eşya", UnitPrice=8000},
                new Product(){UrunName ="Koltuk", CategoryName="Mobilya", UnitPrice=2000},
            };
            return View(products);
        }
    }
}
