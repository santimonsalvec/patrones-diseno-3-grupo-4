using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaNegocio.Entidades
{
    public class EnviarMensaje:IRequest<bool>
    {
        public string De { get; set; }
        public string Para { get; set; }

        public string Mensaje { get; set; }

        public EnviarMensaje(string de, string para, string mensaje) {
            De = de;
            Para = para;
            Mensaje = mensaje;
        }

    }
}
