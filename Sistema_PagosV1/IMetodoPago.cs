﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PagosV1
{
	public interface IMetodoPago
	{
		void ProcesarPago(decimal monto);
	}
}
