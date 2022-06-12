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
	}
}

