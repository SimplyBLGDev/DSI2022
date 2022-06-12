using DSI2022.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI2022.Presentation {
	public partial class PantallaReservarTurno : Form {
		GestorRegistrarReservaTurno gestor;

		public PantallaReservarTurno() {
			InitializeComponent();
			gestor = new GestorRegistrarReservaTurno(this);
			HabilitarPantalla();
		}

		private void HabilitarPantalla() {
			gestor.OpcionReservarTurno();
		}

		public void SolicitarTipoRT(TipoRecursoTecnologico[] tiposDisponibles) {
			PoblarCMBTipoRecursosTecnologicos(tiposDisponibles);
		}

		private void PoblarCMBTipoRecursosTecnologicos(TipoRecursoTecnologico[] tiposDisponibles) {
			cmbTipoRT.Items.Clear();
			cmbTipoRT.SelectedIndex = -1;

			foreach (TipoRecursoTecnologico tipo in tiposDisponibles) {
				ComboBoxItem newItem = new ComboBoxItem();
				newItem.text = tipo.GetNombre();
				newItem.value = tipo;
				cmbTipoRT.Items.Add(newItem);
			}
		}

		private void cmbTipoRT_SelectedIndexChanged(object sender, EventArgs e) {
			btnSeleccionarTipoRecursoTecnologico.Enabled = (cmbTipoRT.SelectedIndex >= 0);
		}

		internal void SolicitarSeleccionRT(List<CentroInvestigacionDisplay> cIDisplay) {
			throw new NotImplementedException();
		}

		private void btnSeleccionarTipoRecursoTecnologico_Click(object sender, EventArgs e) {
			ComboBoxItem seleccionado = cmbTipoRT.SelectedItem as ComboBoxItem;
			gestor.SeleccionarTipoRT(seleccionado.value as TipoRecursoTecnologico);
		}
	}
}
