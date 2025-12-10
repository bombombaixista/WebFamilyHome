using Microsoft.AspNetCore.Mvc;

namespace WebFamilyHome.Controllers
{
    public class ValidateController : Controller
    {
        public IActionResult Index()
        {
            // Aqui você volta a usar o que já estava funcionando antes:
            // pode ser uma View, uma string simples, ou o que você já tinha.
            return View();
            // Se quiser apenas texto direto:
            // return Content("Aplicação validada com sucesso!");
        }
    }
}
