using Microsoft.AspNetCore.Mvc;
using Proyecto.Clientes.MVC.Contexto;
using Proyecto.Clientes.MVC.Entidades;

namespace Proyecto.Clientes.MVC.Controllers
{
    public class ClientesController : Controller
    {
        VentasContext context = new VentasContext();
        public IActionResult Index()
        {
            List<Cliente> ListadoDeClientes = context.Clientes.ToList();
            return View(ListadoDeClientes);
        }
    }
}
