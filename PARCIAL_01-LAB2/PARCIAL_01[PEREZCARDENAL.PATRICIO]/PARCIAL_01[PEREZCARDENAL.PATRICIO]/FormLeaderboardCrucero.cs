using System;
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
    public partial class FormLeaderboardCrucero : Form
    {
        DataTable tablaLeaderboardCruceros = new DataTable();
        DataRow filaLeaderboardCrucero;
        public FormLeaderboardCrucero()
        {
            InitializeComponent();
        }

        private void FormLeaderboardCrucero_Load(object sender, EventArgs e)
        {
            this.tablaLeaderboardCruceros.Columns.Add("CRUCERO");
            this.tablaLeaderboardCruceros.Columns.Add("HORAS");

            BaseDatos.ActualizarLeaderboardCrucero();
            this.CargarDataGridLeaderboardCrucero();
        }

        private void CargarDataGridLeaderboardCrucero()
        {
            foreach (LeaderboardCrucero crucero in BaseDatos.clasificacionCruceros)
            {
                this.filaLeaderboardCrucero = this.tablaLeaderboardCruceros.NewRow();
                this.filaLeaderboardCrucero[0] = crucero.Nombre;
                this.filaLeaderboardCrucero[1] = crucero.Cantidad;
                this.tablaLeaderboardCruceros.Rows.Add(filaLeaderboardCrucero);
            }
            this.dataGridLeaderboardCrucero.DataSource = this.tablaLeaderboardCruceros;
        }
    }
}
