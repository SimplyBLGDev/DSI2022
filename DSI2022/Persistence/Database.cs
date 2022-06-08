using DSI2022.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Persistence {
	public class Database {
		private static string repositoryBase = "Repositories";
		private static string recursosTecnologicosPath = Path.Combine(repositoryBase, "RecursosTecnologicos.json");

		public Database() {
		}
	}
}
