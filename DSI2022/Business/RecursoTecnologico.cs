using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	public class RecursoTecnologico {
		private int id;
		private DateTime fechaAlta;
		private TipoRecursoTecnologico tipo;
		private ValorCaracteristicaRT[] valoresCaracteristicas;
		private List<HistorialEstado> historialEstados;
		private ModeloRT modelo;
		private Turno[] turnos;

		internal bool EsDeTipo(TipoRecursoTecnologico tipo) {
			return this.tipo == tipo;
		}

		internal bool EsActivo() {
			return GetHistorialEstadoActual().EsActivo();
		}

		private HistorialEstado GetHistorialEstadoActual() {
			return historialEstados.Last();
		}

		internal string GetNumero() {
			return id.ToString();
		}

		internal string GetMarca() {
			return modelo.GetMarca();
		}

		internal string GetModelo() {
			return modelo.GetNombre();
		}

		internal string GetEstado() {
			return GetHistorialEstadoActual().GetEstado();
		}
	}
}

