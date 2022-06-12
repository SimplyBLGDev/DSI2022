using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	internal class HistorialEstado {
		private Estado estado;

		public Estado Estado { get => estado; set => estado = value; }

		internal bool EsActivo() {
			return Estado.EsActivo();
		}

		internal string GetEstado() {
			return estado.GetNombre();
		}
	}
}
