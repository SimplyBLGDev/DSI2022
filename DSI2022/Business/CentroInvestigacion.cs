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

		public string Nombre { get => nombre; set => nombre = value; }
		public string Siglas { get => siglas; set => siglas = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public string Edificio { get => edificio; set => edificio = value; }
		public string Piso { get => piso; set => piso = value; }
		public string Coordenadas { get => coordenadas; set => coordenadas = value; }
		public string EMail { get => eMail; set => eMail = value; }
		public string NumeroResolucionCreacion { get => numeroResolucionCreacion; set => numeroResolucionCreacion = value; }
		public DateTime FechaResolucionCreacion { get => fechaResolucionCreacion; set => fechaResolucionCreacion = value; }
		public int Reglamento { get => reglamento; set => reglamento = value; }
		public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
		public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
		public string MotivoBaja { get => motivoBaja; set => motivoBaja = value; }
		public RecursoTecnologico[] RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
		internal AsignacionCientificoDelCI[] Cientificos { get => cientificos; set => cientificos = value; }

		internal RecursoTecnologico[] BuscarRTDeTipo(TipoRecursoTecnologico tipo) {
			List<RecursoTecnologico> validos = new List<RecursoTecnologico>();

			foreach (RecursoTecnologico recursoTecnologico in recursosTecnologicos) {
				if (recursoTecnologico.EsDeTipo(tipo) && recursoTecnologico.EsActivo()) {
					validos.Add(recursoTecnologico);
				}
			}

			return validos.ToArray();
		}

		internal string GetNombre() {
			return Nombre;
		}
	}
}
