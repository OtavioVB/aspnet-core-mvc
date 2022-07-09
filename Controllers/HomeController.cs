using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppClientes.Models;

namespace WebAppClientes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Acessar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Mostrar(InputModel input)
        {
            ClientesModel clientes = new ClientesModel(new NomeModel(input.InputDoUsuario));
            return View(clientes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}