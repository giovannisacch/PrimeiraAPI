using Microsoft.AspNetCore.Mvc;
namespace PrimeiraAPI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeiraController : ControllerBase
    {
        [HttpGet]
        public string PrimeiraAPI(){
            return "Teste";
        }
        [HttpGet("segundaApi")]
        public string SegundaAPI(){
            return "TesteDois";
        }
        [HttpGet("outraAPI")]
        public IActionResult OutraAPI(int entrada){
            if(entrada == 1){
                return BadRequest("1 Não é uma entrada válida");
            }
            
            return Ok("o número de entrada é: " + entrada);
        }
    }
}