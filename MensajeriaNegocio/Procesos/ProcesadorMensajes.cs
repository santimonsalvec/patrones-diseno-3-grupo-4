using MediatR;
using MensajeriaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaNegocio.Procesos
{
    public class ProcesadorMensajes : IRequestHandler<EnviarMensaje, bool>
    {
        public List<string> mensajeslist = new List<string>();
        public Task<bool> Handle(EnviarMensaje mensaje, CancellationToken cancellationToken)
        {
           
            var message = $"Remitente: {mensaje.De}, Destinatario: {mensaje.Para}, Messsage: {mensaje.Mensaje}";
            mensajeslist.Add(message);
            return Task.FromResult(true); 
        }
    }
}
