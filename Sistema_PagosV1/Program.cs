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
	
			var tarjeta = new TarjetaCredito();
			var paypal = new Paypal();
			var nuevoMetodo = new NuevoMetodoPago();
			var adaptadorMetodoSistema = new AdaptadorNuevoMetodoPago(nuevoMetodo);

		
			var plataforma = new PlataformaComercioElectronico();

		
			plataforma.ProcesarPago(tarjeta, 10000);  // Procesa con tarjeta de crédito
			plataforma.ProcesarPago(paypal, 20000);   // Procesa con PayPal
			plataforma.ProcesarPago(adaptadorMetodoSistema, 30000);  // Procesa con el nuevo sistema de pago
		}
	}
}
