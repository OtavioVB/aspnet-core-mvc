using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppClientes.Models;
using WebAppClientes.Models.LoginModel;

namespace WebAppClientes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}