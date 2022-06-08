using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	public class RecursoTecnologico {
		public int id;
		public DateTime fechaAlta;
		public string marca;
		public string modelo;

		public RecursoTecnologico(int id, DateTime fechaAlta, string marca, string modelo) {
			this.id = id;
			this.fechaAlta = fechaAlta;
			this.marca = marca;
			this.modelo = modelo;
		}
	}
}
