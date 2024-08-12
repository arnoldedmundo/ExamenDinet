using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api_es.Models;
using web_api_es.DLAC;
namespace web_api_es.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiNegociosController : ControllerBase
    {
       
        [HttpGet("productos")]
        public async Task<IActionResult> GetSolicitudes()
        {
            return Ok(await Task.Run(() => new productoDLAC().listado()));
        }

       
        
        [HttpPost("registrar")]
        public async Task<IActionResult> PostRegistrar(Producto reg)
        {
            return Ok(await Task.Run(() => new productoDLAC().insertar(reg)));
        }


    }
}