﻿namespace DSI2022.Presentation {
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
			this.cmbTipoRT = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSeleccionarTipoRecursoTecnologico = new System.Windows.Forms.Button();
			this.lsvRecursosTecnologicos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.btnSeleccionarRT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbTipoRT
			// 
			this.cmbTipoRT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTipoRT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbTipoRT.FormattingEnabled = true;
			this.cmbTipoRT.Location = new System.Drawing.Point(172, 12);
			this.cmbTipoRT.Name = "cmbTipoRT";
			this.cmbTipoRT.Size = new System.Drawing.Size(283, 23);
			this.cmbTipoRT.TabIndex = 0;
			this.cmbTipoRT.SelectedIndexChanged += new System.EventHandler(this.cmbTipoRT_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tipo Recurso Tecnologico";
			// 
			// btnSeleccionarTipoRecursoTecnologico
			// 
			this.btnSeleccionarTipoRecursoTecnologico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSeleccionarTipoRecursoTecnologico.Enabled = false;
			this.btnSeleccionarTipoRecursoTecnologico.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
			this.lsvRecursosTecnologicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lsvRecursosTecnologicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvRecursosTecnologicos.Enabled = false;
			this.lsvRecursosTecnologicos.FullRowSelect = true;
			listViewGroup1.Header = "CI 1";
			listViewGroup1.Name = "listViewGroup1";
			this.lsvRecursosTecnologicos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
			this.lsvRecursosTecnologicos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			listViewItem1.Group = listViewGroup1;
			this.lsvRecursosTecnologicos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.lsvRecursosTecnologicos.Location = new System.Drawing.Point(12, 89);
			this.lsvRecursosTecnologicos.MultiSelect = false;
			this.lsvRecursosTecnologicos.Name = "lsvRecursosTecnologicos";
			this.lsvRecursosTecnologicos.Size = new System.Drawing.Size(443, 387);
			this.lsvRecursosTecnologicos.TabIndex = 3;
			this.lsvRecursosTecnologicos.UseCompatibleStateImageBehavior = false;
			this.lsvRecursosTecnologicos.View = System.Windows.Forms.View.Details;
			this.lsvRecursosTecnologicos.SelectedIndexChanged += new System.EventHandler(this.lsvRecursosTecnologicos_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 20;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Modelo";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Marca";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Estado";
			this.columnHeader4.Width = 80;
			// 
			// btnSeleccionarRT
			// 
			this.btnSeleccionarRT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSeleccionarRT.Enabled = false;
			this.btnSeleccionarRT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSeleccionarRT.Location = new System.Drawing.Point(12, 482);
			this.btnSeleccionarRT.Name = "btnSeleccionarRT";
			this.btnSeleccionarRT.Size = new System.Drawing.Size(443, 42);
			this.btnSeleccionarRT.TabIndex = 4;
			this.btnSeleccionarRT.Text = "Seleccionar";
			this.btnSeleccionarRT.UseVisualStyleBackColor = true;
			this.btnSeleccionarRT.Click += new System.EventHandler(this.btnSeleccionarRT_Click);
			// 
			// PantallaReservarTurno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(467, 536);
			this.Controls.Add(this.btnSeleccionarRT);
			this.Controls.Add(this.lsvRecursosTecnologicos);
			this.Controls.Add(this.btnSeleccionarTipoRecursoTecnologico);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbTipoRT);
			this.Name = "PantallaReservarTurno";
			this.Text = "PantallaReservarTurno";
			this.ResumeLayout(false);

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
		private Button btnSeleccionarRT;
	}
}