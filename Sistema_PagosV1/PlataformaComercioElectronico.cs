using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PagosV1
{
	public class PlataformaComercioElectronico
	{
		public void ProcesarPago(IMetodoPago metodoPago, decimal monto)
		{
			metodoPago.ProcesarPago(monto);
		}
	}
}