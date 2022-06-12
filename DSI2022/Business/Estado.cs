using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	internal class Estado {
		private string nombre;

		public string Nombre { get => nombre; set => nombre = value; }

		internal bool EsActivo() {
			return Nombre != "DeBajaTecnica" && Nombre != "DeBajaDefinitiva";
		}

		internal string GetNombre() {
			return Nombre;
		}
	}
}
