﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PARCIAL_01_BIBLIOTECA_;

namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            this.labelGananciaRegionalValor.Text = $"{BaseDatos.estadisticas.GananciaRegional.ToString():c}";
            this.labelGananciaExtraRegionalValor.Text = $"{BaseDatos.estadisticas.GananciaExtraRegional.ToString():c}";
        }

        private void btnMostrarLeaderboardCrucero_Click(object sender, EventArgs e)
        {
            FormLeaderboardCrucero formLeaderboard = new FormLeaderboardCrucero();
            formLeaderboard.ShowDialog();

        }

        private void btnMostrarPasajerosFrecuentes_Click(object sender, EventArgs e)
        {
            FormLeaderboardPasajeros formLeaderboard = new FormLeaderboardPasajeros();
            formLeaderboard.ShowDialog();
        }
    }
}
