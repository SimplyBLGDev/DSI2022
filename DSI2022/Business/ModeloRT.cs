using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	public class ModeloRT {
		private string nombre;
		private MarcaRT marca;

		public ModeloRT(string nombre, MarcaRT marca) {
			this.nombre = nombre;
			this.marca = marca;
		}

		public string Nombre { get => nombre; set => nombre = value; }
		public MarcaRT Marca { get => marca; set => marca = value; }

		internal string GetMarca() {
			return marca.GetNombre();
		}

		internal string GetNombre() {
			return nombre;
		}
	}
}
