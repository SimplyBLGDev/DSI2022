using DSI2022.Business;

namespace DSI2022.Presentation {
	public partial class PantallaReservarTurno : Form {
		private Dictionary<string, Color> COLORES_ESTADOS = new Dictionary<string, Color>();
		GestorRegistrarReservaTurno gestor;

		public PantallaReservarTurno() {
			InitializeComponent();
			COLORES_ESTADOS.Add("Disponible", Color.Blue);
			COLORES_ESTADOS.Add("En Mantenimiento", Color.Green);
			COLORES_ESTADOS.Add("Mantenimiento Correctivo", Color.Gray);
			
			HabilitarPantalla();
		}

		private void HabilitarPantalla() {
			lsvRecursosTecnologicos.Items.Clear();
			lsvRecursosTecnologicos.Groups.Clear();
			gestor = new GestorRegistrarReservaTurno(this);

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
			lsvRecursosTecnologicos.Enabled = true;
			lsvRecursosTecnologicos.Items.Clear();
			lsvRecursosTecnologicos.Groups.Clear();

			foreach (CentroInvestigacionDisplay display in cIDisplay) {
				CrearListViewCentroInvestigacion(display);
			}
		}

		private ListViewGroup CrearListViewCentroInvestigacion(CentroInvestigacionDisplay display) {
			ListViewGroup newGroup = new ListViewGroup(display.nombre);
			lsvRecursosTecnologicos.Groups.Add(newGroup);
			newGroup.Tag = display.from;

			foreach (RecursoTecnologicoDisplay rec in display.recursos) {
				ListViewItem newItem = CrearListViewRecursoTecnologico(rec, newGroup);
				lsvRecursosTecnologicos.Items.Add(newItem);
			}

			return newGroup;
		}

		private ListViewItem CrearListViewRecursoTecnologico(RecursoTecnologicoDisplay rec, ListViewGroup group) {
			ListViewItem newItem = new ListViewItem();

			newItem.Group = group;
			newItem.Text = rec.numero;
			newItem.SubItems.Add(rec.modelo);
			newItem.SubItems.Add(rec.marca);
			newItem.SubItems.Add(rec.estado);
			newItem.Tag = rec.from;
			newItem.ForeColor = COLORES_ESTADOS[rec.estado];

			return newItem;
		}

		private void btnSeleccionarTipoRecursoTecnologico_Click(object sender, EventArgs e) {
			ComboBoxItem seleccionado = cmbTipoRT.SelectedItem as ComboBoxItem;
			gestor.SeleccionarTipoRT(seleccionado.value as TipoRecursoTecnologico);
		}

		private void lsvRecursosTecnologicos_SelectedIndexChanged(object sender, EventArgs e) {
			btnSeleccionarRT.Enabled = (lsvRecursosTecnologicos.SelectedIndices.Count == 1);
		}

		private void btnSeleccionarRT_Click(object sender, EventArgs e) {
			CentroInvestigacion cISeleccionado = lsvRecursosTecnologicos.SelectedItems[0].Group.Tag as CentroInvestigacion;
			RecursoTecnologico seleccionado = lsvRecursosTecnologicos.SelectedItems[0].Tag as RecursoTecnologico;
			gestor.SeleccionarRecursoTecnologico(cISeleccionado, seleccionado);
		}
	}
}
