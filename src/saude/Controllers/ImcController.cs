using Microsoft.AspNetCore.Mvc;
using saude.Model;

namespace saude.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImcController : ControllerBase
    {
           
        [HttpPost]
        public IActionResult Post(Imc imc)
        {
            var resultado = imc.Peso / (imc.Altura * imc.Altura);
            return Ok(resultado);
        }
    }
}