using GettingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(Product product)
        {
            return "Uygulama Çalışıyor";
        }
        public string UseQueryString(string name, string surname)//Buradaki 'name' parametre adı query stringdeki ile aynı olmalı, sıralaması önemli değil.
        {
            return "Uygulama Çalışıyor1";
        }

    }
}
