using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PagosV1
{
	internal class AdaptadorNuevoMetodoPago : IMetodoPago
	{
		private readonly NuevoMetodoPago _nuevoMetodoPago;

		public AdaptadorNuevoMetodoPago(NuevoMetodoPago nuevoSistemaPago)
		{
			_nuevoMetodoPago = nuevoSistemaPago;
		}

		public void ProcesarPago(decimal monto)
		{
			_nuevoMetodoPago.RealizarPago(monto);
		}
	}

}

