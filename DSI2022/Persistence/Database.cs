using DSI2022.Business;

namespace DSI2022.Persistence {
	public static class Database {
		private static string repositoryBase = "Repositories";
		private static string centrosInvestigacionPath = Path.Combine(repositoryBase, "CentrosInvestigacion.json");
		private static string tiposRecursosTecnologicosPath = Path.Combine(repositoryBase, "TiposRT.json");
		private static string estadosPath = Path.Combine(repositoryBase, "Estados.json");

		public static TipoRecursoTecnologico[] FetchTiposRT() {
			Repository<TipoRecursoTecnologico> tipos =
				new Repository<TipoRecursoTecnologico>(tiposRecursosTecnologicosPath);

			return tipos.ToArray();
		}

		public static Estado[] FetchEstados() {
			Repository<Estado> estados =
				new Repository<Estado>(estadosPath);

			return estados.ToArray();
		}

		public static CentroInvestigacion[] FetchCentrosInvestigacion() {
			Repository<CentroInvestigacion> centros =
				new Repository<CentroInvestigacion>(centrosInvestigacionPath);

			return centros.ToArray();
		}

		private static void GenerarTurnosParaCI(Repository<CentroInvestigacion> centros) {
			List<Turno> turnos = new List<Turno>();
			var rng = new Random();

			for (int j = 0; j < 30; j++) {
				for (int i = 0; i < 10; i++) {
					DateTime from = DateTime.Today.AddMinutes(i * 30).AddDays(j);
					DateTime to = DateTime.Today.AddMinutes((i + 1) * 30).AddDays(j);
					string estadoS = "Disponible";

					switch (rng.Next() % 4) {
						case 0: estadoS = "Disponible"; break;
						case 1: estadoS = "Reservado"; break;
						case 2: estadoS = "PendienteConfirmacion"; break;
						case 3: estadoS = "Disponible"; break;
					}

					turnos.Add(new Turno(from, to, new List<HistorialEstado>() {
						new HistorialEstado(new Estado(estadoS))
					}));
				}
			}

			foreach (CentroInvestigacion ci in centros) {
				foreach (RecursoTecnologico rt in ci.RecursosTecnologicos) {
					rt.Turnos = turnos.ToArray();
				}
			}

			centros.Commit();
		}
	}
}
