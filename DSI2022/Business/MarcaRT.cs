using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	public class MarcaRT {
		private string nombre;

		public MarcaRT(string nombre) {
			this.nombre = nombre;
		}

		public string Nombre { get => nombre; set => nombre = value; }

		internal string GetNombre() {
			return nombre;
		}
	}
}
