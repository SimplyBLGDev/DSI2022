using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Presentation {
	public class CentroInvestigacionDisplay {
		public string nombre;
		public RecursoTecnologicoDisplay[] recursos;

		public CentroInvestigacionDisplay(string nombre, RecursoTecnologicoDisplay[] recursos) {
			this.nombre = nombre;
			this.recursos = recursos;
		}
	}
}
