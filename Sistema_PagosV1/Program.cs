using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PagosV1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Crear instancias de los métodos de pago
			var tarjeta = new TarjetaCredito();
			var paypal = new Paypal();
			var nuevoMetodo = new NuevoMetodoPago();
			var adaptadorNuevoSistema = new AdaptadorNuevoMetodoPago(nuevoMetodo);

			// Crear la plataforma de comercio electrónico
			var plataforma = new PlataformaComercioElectronico();

			// Procesar pagos con diferentes métodos
			plataforma.ProcesarPago(tarjeta, 10000);  // Procesa con tarjeta de crédito
			plataforma.ProcesarPago(paypal, 20000);   // Procesa con PayPal
			plataforma.ProcesarPago(adaptadorNuevoSistema, 30000);  // Procesa con el nuevo sistema de pago
		}
	}
}
