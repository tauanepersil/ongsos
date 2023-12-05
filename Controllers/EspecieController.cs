using Microsoft.AspNetCore.Mvc;
using SOS.Dados;

namespace SOS.WEBAPP.Controllers
{
    public class EspecieController : Controller
    {
        public IActionResult Index()
        {
            var contexto = new Contexto();

            return View(contexto.Especie.ToList());
        }
    }
}
