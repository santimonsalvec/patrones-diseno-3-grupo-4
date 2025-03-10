using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PagosV1
{
	public class TarjetaCredito : IMetodoPago
	{
		public void ProcesarPago(decimal monto)
		{
			Console.WriteLine($"Procesando pago de {monto} con tarjeta de crédito");
		}

	}
}
