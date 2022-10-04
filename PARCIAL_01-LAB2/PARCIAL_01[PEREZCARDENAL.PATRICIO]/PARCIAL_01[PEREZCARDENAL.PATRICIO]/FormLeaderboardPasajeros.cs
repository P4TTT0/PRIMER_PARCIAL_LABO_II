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
    public partial class FormLeaderboardPasajeros : Form
    {
        DataTable tablaLeaderboardPasajeros = new DataTable();
         DataRow filaLeaderboardPasajeros;
        public FormLeaderboardPasajeros()
        {
            InitializeComponent();
        }

        private void FormLeaderboardPasajeros_Load(object sender, EventArgs e)
        {
            this.tablaLeaderboardPasajeros.Columns.Add("NOMBRE");
            this.tablaLeaderboardPasajeros.Columns.Add("APELLIDO");
            this.tablaLeaderboardPasajeros.Columns.Add("CANTIDAD VIAJES");

            BaseDatos.ActualizarLeaderboardPasajeros();
            this.CargarDataGridLeaderboardpPasajeros();
        }

        private void CargarDataGridLeaderboardpPasajeros()
        {
            foreach (LeaderboardPasajeros pasajero in BaseDatos.clasificacionPasajeros)
            {
                this.filaLeaderboardPasajeros = this.tablaLeaderboardPasajeros.NewRow();
                this.filaLeaderboardPasajeros[0] = pasajero.Nombre;
                this.filaLeaderboardPasajeros[1] = pasajero.Apellido;
                this.filaLeaderboardPasajeros[2] = pasajero.Cantidad;
                this.tablaLeaderboardPasajeros.Rows.Add(filaLeaderboardPasajeros);
            }
            this.dataGridLeaderboardPasajero.DataSource = this.tablaLeaderboardPasajeros;
        }
    }
}
