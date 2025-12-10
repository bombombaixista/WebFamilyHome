using Microsoft.AspNetCore.Mvc;

namespace WebFamilyHome.Controllers
{
    public class ValidateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Renderiza a tela de validação (Views/Validate/Index.cshtml)
            return View();
        }

        [HttpPost]
        public IActionResult Index(string token)
        {
            if (token == "minha_chave_secreta")
            {
                // ✅ Token válido → redireciona para o Kanban
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // ❌ Token inválido → mostra erro na própria tela
                ViewBag.Erro = "Token inválido!";
                return View();
            }
        }
    }
}
