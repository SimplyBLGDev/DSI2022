namespace DSI2022.Business {
	public class HistorialEstado {
		private Estado estado;

		public Estado Estado { get => estado; set => estado = value; }

		public HistorialEstado(Estado estado) {
			this.estado = estado;
		}

		internal bool EsActivo() {
			return Estado.EsActivo();
		}

		internal string GetEstado() {
			return estado.GetNombre();
		}
	}
}
