using Microsoft.AspNetCore.Mvc;
using SOS.WEBAPP.Models;

namespace SOS.WEBAPP.Controllers
{
    public class AutenticacaoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UsuarioViewModel());
        }

        public IActionResult CadastroUsuario()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Autenticar(UsuarioViewModel entidade)
        {
            if (entidade.Autenticado())
                return base.RedirectToAction("Index", "Home");
            else
                return base.RedirectToAction("Erro");
        }

        [HttpGet]
        public IActionResult Erro()
        {
            return View();
        }
    }
}
