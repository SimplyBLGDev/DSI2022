using DSI2022.Persistence;
using DSI2022.Presentation;
using DSI2022.Security;

namespace DSI2022.Business {
	public class GestorRegistrarReservaTurno {
		private PantallaReservarTurno pantalla;
		private TipoRecursoTecnologico[] tiposRecursoTecnologico;
		private CentroInvestigacion[] centrosInvestigacion;
		private Estado[] estados;

		public GestorRegistrarReservaTurno(PantallaReservarTurno pantalla) {
			estados = Database.FetchEstados();
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
				Turno[] turnosValidos = seleccionado.GetTurnos(GetFechaHoraActual());

				turnosValidos = OrdernarTurnos(turnosValidos);

				TurnoDisplay[] displays = GetTurnosDisplay(turnosValidos, seleccionado);
				TurnoDiaDisplay[] diaTurnos = AgruparPorDia(displays);

				pantalla.SolicitarSeleccionTurno(diaTurnos);
			}
		}

		private TurnoDiaDisplay[] AgruparPorDia(TurnoDisplay[] turnos) {
			List<TurnoDiaDisplay> turnoDias = new List<TurnoDiaDisplay>();

			DateOnly date = turnos[0].GetFromDate();
			TurnoDiaDisplay currentTDD = new TurnoDiaDisplay(date);

			foreach (TurnoDisplay turno in turnos) {
				if (date == turno.GetFromDate())
					currentTDD.Add(turno);
				else {
					date = turno.GetFromDate();
					turnoDias.Add(currentTDD);
					currentTDD = new TurnoDiaDisplay(date);
				}
			}

			turnoDias.Add(currentTDD);
			return turnoDias.ToArray();
		}

		private TurnoDisplay[] GetTurnosDisplay(Turno[] turnos, RecursoTecnologico rt) {
			List<TurnoDisplay> ret = new List<TurnoDisplay>();

			foreach (Turno turno in turnos) {
				TurnoDisplay turnoDisplay = new TurnoDisplay(turno, rt);
				ret.Add(turnoDisplay);
			}

			return ret.ToArray();
		}

		private Turno[] OrdernarTurnos(Turno[] turnosValidos) {
			List<Turno> turnos = new List<Turno>(turnosValidos);
			turnos.Sort();

			return turnos.ToArray();
		}

		private DateTime GetFechaHoraActual() {
			return DateTime.Now;
		}

		private bool VerificarPerteneceAlLogeado(CentroInvestigacion centroInvestigacion, RecursoTecnologico recurso) {
			PersonalCientifico logeado = SessionManager.GetCientifico();

			//return centroInvestigacion.TrabajaCientifico(logeado) && centroInvestigacion.ContieneRecurso(recurso);
			return true;
		}

		internal void ReservarTurno(Turno turno) {
			Estado reservado = GetEstado("Reservado");
			turno.Reservar(reservado);

			EnviarMailNotificacion(turno);
			FinCU();
		}

		private void FinCU() {
			MessageBox.Show("Fin CU");
		}

		private void EnviarMailNotificacion(Turno turno) {
			
		}

		private Estado GetEstado(string v) {
			foreach (Estado estado in estados) {
				if (estado.GetNombre() == v)
					return estado;
			}

			return null;
		}
	}
}
