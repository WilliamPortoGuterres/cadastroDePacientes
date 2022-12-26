using Microsoft.AspNetCore.Mvc;

namespace cadastroDePacientes.Controllers
{
    public class ListarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Colaboradores()
        {
            return View();
        }

    }
}
