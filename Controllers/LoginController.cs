using Microsoft.AspNetCore.Mvc;
using WebAppClientes.Models.LoginModel;

namespace WebAppClientes.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Acessar(InputLoginModel LoginModel)
        {
            if (LoginModel.Email == "otaviovb.developer@gmail.com" && LoginModel.Password == "1234")
            {
                return RedirectToAction("Index", "Usuario", LoginModel);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
