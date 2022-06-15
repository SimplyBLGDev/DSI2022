using DSI2022.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Persistence {
	public static class Database {
		private static string repositoryBase = "Repositories";
		private static string centrosInvestigacionPath = Path.Combine(repositoryBase, "CentrosInvestigacion.json");
		private static string recursosTecnologicosPath = Path.Combine(repositoryBase, "RecursosTecnologicos.json");
		private static string tiposRecursosTecnologicosPath = Path.Combine(repositoryBase, "TiposRT.json");

		public static TipoRecursoTecnologico[] FetchTiposRT() {
			Repository<TipoRecursoTecnologico> tipos =
				new Repository<TipoRecursoTecnologico>(tiposRecursosTecnologicosPath);

			return tipos.ToArray();
		}

		public static CentroInvestigacion[] FetchCentrosInvestigacion() {
			Repository<CentroInvestigacion> centros =
				new Repository<CentroInvestigacion>(centrosInvestigacionPath);

			return centros.ToArray();
		}
	}
}
