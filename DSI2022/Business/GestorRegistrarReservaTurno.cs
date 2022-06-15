using DSI2022.Persistence;
using DSI2022.Presentation;
using DSI2022.Security;

namespace DSI2022.Business {
	public class GestorRegistrarReservaTurno {
		private PantallaReservarTurno pantalla;
		private TipoRecursoTecnologico[] tiposRecursoTecnologico;
		private CentroInvestigacion[] centrosInvestigacion;

		public GestorRegistrarReservaTurno(PantallaReservarTurno pantalla) {
			tiposRecursoTecnologico = Database.FetchTiposRT();
			centrosInvestigacion = Database.FetchCentrosInvestigacion();
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
			CentroInvestigacionDisplay cIDisplay = new CentroInvestigacionDisplay(centroInvestigacion, nombre, rTDisplay);

			return cIDisplay;
		}

		private RecursoTecnologicoDisplay[] GetRTDisplay(RecursoTecnologico[] rTSinBaja) {
			List<RecursoTecnologicoDisplay> recursos = new List<RecursoTecnologicoDisplay>();

			foreach (RecursoTecnologico seleccionado in rTSinBaja) {
				RecursoTecnologicoDisplay rTDisplay = new RecursoTecnologicoDisplay(
						from: seleccionado,
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

		internal void SeleccionarRecursoTecnologico(CentroInvestigacion cISeleccionado, RecursoTecnologico seleccionado) {
			if (VerificarPerteneceAlLogeado(cISeleccionado, seleccionado)) {

			}
		}

		private bool VerificarPerteneceAlLogeado(CentroInvestigacion centroInvestigacion, RecursoTecnologico recurso) {
			PersonalCientifico logeado = SessionManager.GetCientifico();

			return centroInvestigacion.TrabajaCientifico(logeado) && centroInvestigacion.ContieneRecurso(recurso);
		}
	}
}
