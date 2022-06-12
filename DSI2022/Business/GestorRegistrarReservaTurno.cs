using DSI2022.Persistence;
using DSI2022.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	public class GestorRegistrarReservaTurno {
		private PantallaReservarTurno pantalla;
		private TipoRecursoTecnologico[] tiposRecursoTecnologico;
		private CentroInvestigacion[] centrosInvestigacion;

		public GestorRegistrarReservaTurno(PantallaReservarTurno pantalla) {
			tiposRecursoTecnologico = Database.FetchTiposRT();
			this.pantalla = pantalla;
		}

		public void OpcionReservarTurno() {
			TipoRecursoTecnologico[] tiposDisponibles = GetTiposRT();
			pantalla.SolicitarTipoRT(tiposDisponibles);
		}

		private TipoRecursoTecnologico[] GetTiposRT() {
			return tiposRecursoTecnologico;
		}

		internal void SeleccionarTipoRT(TipoRecursoTecnologico seleccionado) {
			List<CentroInvestigacionDisplay> cIDisplay = new List<CentroInvestigacionDisplay>();

			foreach (CentroInvestigacion centroInvestigacion in centrosInvestigacion) {
				RecursoTecnologico[] rTSinBaja = BuscarRTSinBajaDeTipo(seleccionado, centroInvestigacion);

				cIDisplay.Add(GenerarCIDisplay(centroInvestigacion, rTSinBaja));
			}

			pantalla.SolicitarSeleccionRT(cIDisplay);
		}

		private CentroInvestigacionDisplay GenerarCIDisplay(CentroInvestigacion centroInvestigacion, RecursoTecnologico[] rTSinBaja) {
			string nombre = centroInvestigacion.GetNombre();
			RecursoTecnologicoDisplay[] rTDisplay = GetRTDisplay(rTSinBaja);
			CentroInvestigacionDisplay cIDisplay = new CentroInvestigacionDisplay(nombre, rTDisplay);

			return cIDisplay;
		}

		private RecursoTecnologicoDisplay[] GetRTDisplay(RecursoTecnologico[] rTSinBaja) {
			List<RecursoTecnologicoDisplay> recursos = new List<RecursoTecnologicoDisplay>();

			foreach (RecursoTecnologico seleccionado in rTSinBaja) {
				RecursoTecnologicoDisplay rTDisplay = new RecursoTecnologicoDisplay(
						numero: seleccionado.GetNumero(),
						marca: seleccionado.GetMarca(),
						modelo: seleccionado.GetModelo(),
						estado: seleccionado.GetEstado()
					);
				recursos.Add(rTDisplay);
			}

			return recursos.ToArray();
		}

		private RecursoTecnologico[] BuscarRTSinBajaDeTipo(TipoRecursoTecnologico tipo, CentroInvestigacion centroInvestigacion) {
			List<RecursoTecnologico> encontrados = new List<RecursoTecnologico>();

			encontrados.AddRange(centroInvestigacion.BuscarRTDeTipo(tipo));

			return encontrados.ToArray();
		}
	}
}
