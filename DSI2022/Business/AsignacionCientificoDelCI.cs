﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2022.Business {
	public class AsignacionCientificoDelCI {
		private PersonalCientifico cientifico;
		private DateTime fechaDesde;
		private DateTime fechaHasta;

		public AsignacionCientificoDelCI(PersonalCientifico cientifico, DateTime fechaDesde, DateTime fechaHasta) {
			this.cientifico = cientifico;
			this.fechaDesde = fechaDesde;
			this.fechaHasta = fechaHasta;
		}

		public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }
		public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
		public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }

		internal bool EsCientifico(PersonalCientifico logeado) {
			return cientifico.EsCientifico(logeado);
		}
	}
}
