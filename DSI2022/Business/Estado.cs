namespace DSI2022.Business {
	public class Estado {
		private string nombre;

		public Estado(string nombre) {
			this.nombre = nombre;
		}

		internal bool EsActivo() {
			return nombre != "DeBajaTecnica" && nombre != "DeBajaDefinitiva";
		}

		internal string GetNombre() {
			return nombre;
		}
	}
}
