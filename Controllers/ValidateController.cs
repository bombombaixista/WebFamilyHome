using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ValidateController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // lógica de validação (ex: checar licença, token, etc.)
        return Ok(new { status = "valid" });
    }
}
