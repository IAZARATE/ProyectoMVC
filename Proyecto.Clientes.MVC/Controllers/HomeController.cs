using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Clientes.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Index), "Vendedores");
        }
    }
}
