using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	internal class CentroInvestigacion {
		private string nombre;
		private string siglas;
		private string direccion;
		private string edificio;
		private string piso;
		private string coordenadas;
		private string eMail;
		private string numeroResolucionCreacion;
		private DateTime fechaResolucionCreacion;
		private int reglamento;
		private DateTime fechaAlta;
		private DateTime fechaBaja;
		private string motivoBaja;
		private RecursoTecnologico[] recursosTecnologicos;
		private AsignacionCientificoDelCI[] cientificos;
	}
}
