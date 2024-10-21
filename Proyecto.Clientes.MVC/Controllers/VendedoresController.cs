using Microsoft.AspNetCore.Mvc;
using Proyecto.Clientes.MVC.Contexto;
using Proyecto.Clientes.MVC.Entidades;

namespace Proyecto.Clientes.MVC.Controllers
{
    public class VendedoresController : Controller
    {
        VentasContext context = new VentasContext();
        public IActionResult Index()
        {
            List<Vendedor> ListadoDeVendedores = context.Vendedores.ToList();
            return View(ListadoDeVendedores);
        }
    }
}
