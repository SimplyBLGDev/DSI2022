namespace DSI2022.Presentation {
	partial class PantallaReservarTurno {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("CI 1", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("RT 1");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("RT 2");
			this.cmbTipoRT = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSeleccionarTipoRecursoTecnologico = new System.Windows.Forms.Button();
			this.lsvRecursosTecnologicos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// cmbTipoRT
			// 
			this.cmbTipoRT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTipoRT.FormattingEnabled = true;
			this.cmbTipoRT.Location = new System.Drawing.Point(160, 12);
			this.cmbTipoRT.Name = "cmbTipoRT";
			this.cmbTipoRT.Size = new System.Drawing.Size(295, 23);
			this.cmbTipoRT.TabIndex = 0;
			this.cmbTipoRT.SelectedIndexChanged += new System.EventHandler(this.cmbTipoRT_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tipo Recurso Tecnologico";
			// 
			// btnSeleccionarTipoRecursoTecnologico
			// 
			this.btnSeleccionarTipoRecursoTecnologico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSeleccionarTipoRecursoTecnologico.Enabled = false;
			this.btnSeleccionarTipoRecursoTecnologico.Location = new System.Drawing.Point(12, 41);
			this.btnSeleccionarTipoRecursoTecnologico.Name = "btnSeleccionarTipoRecursoTecnologico";
			this.btnSeleccionarTipoRecursoTecnologico.Size = new System.Drawing.Size(443, 42);
			this.btnSeleccionarTipoRecursoTecnologico.TabIndex = 2;
			this.btnSeleccionarTipoRecursoTecnologico.Text = "Seleccionar";
			this.btnSeleccionarTipoRecursoTecnologico.UseVisualStyleBackColor = true;
			this.btnSeleccionarTipoRecursoTecnologico.Click += new System.EventHandler(this.btnSeleccionarTipoRecursoTecnologico_Click);
			// 
			// lsvRecursosTecnologicos
			// 
			this.lsvRecursosTecnologicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsvRecursosTecnologicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvRecursosTecnologicos.FullRowSelect = true;
			listViewGroup1.Header = "CI 1";
			listViewGroup1.Name = "listViewGroup1";
			this.lsvRecursosTecnologicos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
			listViewItem1.Group = listViewGroup1;
			listViewItem2.Group = listViewGroup1;
			this.lsvRecursosTecnologicos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lsvRecursosTecnologicos.Location = new System.Drawing.Point(12, 89);
			this.lsvRecursosTecnologicos.Name = "lsvRecursosTecnologicos";
			this.lsvRecursosTecnologicos.Size = new System.Drawing.Size(443, 425);
			this.lsvRecursosTecnologicos.TabIndex = 3;
			this.lsvRecursosTecnologicos.UseCompatibleStateImageBehavior = false;
			this.lsvRecursosTecnologicos.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nombre";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Marca";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Modelo";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Numero";
			// 
			// PantallaReservarTurno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 526);
			this.Controls.Add(this.lsvRecursosTecnologicos);
			this.Controls.Add(this.btnSeleccionarTipoRecursoTecnologico);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbTipoRT);
			this.Name = "PantallaReservarTurno";
			this.Text = "PantallaReservarTurno";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox cmbTipoRT;
		private Label label1;
		private Button btnSeleccionarTipoRecursoTecnologico;
		private ListView lsvRecursosTecnologicos;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
	}
}