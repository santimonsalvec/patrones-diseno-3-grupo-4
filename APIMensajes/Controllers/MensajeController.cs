using MediatR;
using MensajeriaNegocio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIMensajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajeController : ControllerBase
    {
        private readonly IMediator _gestion;

        public MensajeController(IMediator mediador)
        {
            _gestion = mediador;
        }

        [HttpPost]
        [Route("enviarMensaje")]
        public async Task<IActionResult> EnviarMensaje([FromBody] EnviarMensaje enviarMensaje) {

            if (enviarMensaje is not null) {
                
                bool resultMensaje = await _gestion.Send(enviarMensaje);
                if (resultMensaje) { return Ok("Mensaje Enviado"); } else { return BadRequest("Mensaje no enviado"); }
            }
            return BadRequest("Error al enviar el mensaje");
        }

    }
}
