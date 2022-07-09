using Microsoft.AspNetCore.Mvc;
using WebAppClientes.Models.LoginModel;

namespace WebAppClientes.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index(InputLoginModel inputLogin)
        {
            if (inputLogin.Email == "otaviovb.developer@gmail.com" && inputLogin.Password == "1234")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
