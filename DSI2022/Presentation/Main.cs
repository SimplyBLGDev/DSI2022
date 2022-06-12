using DSI2022.Persistence;
using DSI2022.Presentation;

namespace DSI2022 {
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}

		private void btnReservarTurno_Click(object sender, EventArgs e) {
			PantallaReservarTurno pantallaReservarTurno = new PantallaReservarTurno();
			pantallaReservarTurno.Show();
		}
	}
}