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
    public partial class FormMostrarPasajeros : Form
    {
        DataTable tablaViajes = new DataTable();
        DataRow filaViajes;
        DataTable tablaPasajeros = new DataTable();
        DataRow filaAuxPasajeros;
        int indiceViajeSeleccionado = 0;
        Pasajero auxPasajero = null;
        public FormMostrarPasajeros()
        {
            InitializeComponent();
        }

        private void FormMostrarPasajeros_Load(object sender, EventArgs e)
        {
            this.tablaPasajeros.Columns.Add("NOMBRE");
            this.tablaPasajeros.Columns.Add("APELLIDO");
            this.tablaPasajeros.Columns.Add("EDAD");
            this.tablaPasajeros.Columns.Add("DNI");
            this.tablaPasajeros.Columns.Add("GENERO");
            this.tablaPasajeros.Columns.Add("ES PREMIUM");

            this.tablaViajes.Columns.Add("PARTIDA");
            this.tablaViajes.Columns.Add("LLEGADA");
            this.tablaViajes.Columns.Add("DESTINO");
            this.tablaViajes.Columns.Add("CRUCERO");
            this.tablaViajes.Columns.Add("MATRICULA");
            this.tablaViajes.Columns.Add("ESTADO");

            this.CargarDataGridViajes();
        }

        private void dataGridViajes_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            this.CargarDataGridPasajero(indice, out this.indiceViajeSeleccionado);

        }

        private void CargarDataGridViajes()
        {
            foreach (Viaje viaje in BaseDatos.viajes)
            {
                this.filaViajes = this.tablaViajes.NewRow();
                this.filaViajes[0] = $"{viaje.FechaInicioViaje:d}";
                this.filaViajes[1] = $"{viaje.FechaFinalViaje:d}";
                this.filaViajes[2] = viaje.Destino;
                this.filaViajes[3] = viaje.Crucero;
                this.filaViajes[4] = viaje.Crucero.Matricula;
                this.filaViajes[5] = viaje.EstadoViaje;
                this.tablaViajes.Rows.Add(filaViajes);
            }
            this.dataGridViajes.DataSource = this.tablaViajes;
        }

        private void CargarDataGridPasajero(int indice, out int viajeSeleccionado)
        {
            viajeSeleccionado = -1;
            this.tablaPasajeros.Clear();

            foreach (Viaje viaje in BaseDatos.viajes)
            {
                if (indice > -1)
                {
                    viajeSeleccionado++;
                    if (viaje == this.dataGridViajes.Rows[indice].Cells[3].Value.ToString() && viaje.FechaInicioViaje == DateTime.Parse(this.dataGridViajes.Rows[indice].Cells[0].Value.ToString()))
                    {
                        foreach (Pasajero pasajero in viaje.Pasajeros)
                        {
                            this.filaAuxPasajeros = this.tablaPasajeros.NewRow();
                            this.filaAuxPasajeros[0] = pasajero.Nombre;
                            this.filaAuxPasajeros[1] = pasajero.Apellido;
                            this.filaAuxPasajeros[2] = pasajero.Edad;
                            this.filaAuxPasajeros[3] = pasajero.pasaporte.Dni;
                            this.filaAuxPasajeros[4] = pasajero.Genero;
                            this.filaAuxPasajeros[5] = pasajero.EsPremium;
                            this.tablaPasajeros.Rows.Add(filaAuxPasajeros);
                        }
                        this.dataGridView1.DataSource = this.tablaPasajeros;
                        break;
                    }
                }
            }
        }

        private void btnMostrarInfoDetallada_Click(object sender, EventArgs e)
        {
            if (this.auxPasajero is not null)
            {
                FormInfoDetalladaPasajero formInfoPasajero = new FormInfoDetalladaPasajero(this.auxPasajero);
                if (formInfoPasajero.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private Pasajero SeleccionarPasajero(int indiceFilaSeleccionada)
        {
            Pasajero auxPasajero = null;
            foreach (Pasajero pasajero in BaseDatos.viajes[this.indiceViajeSeleccionado].Pasajeros)
            {
                if (pasajero == int.Parse(this.dataGridView1.Rows[indiceFilaSeleccionada].Cells[3].Value.ToString()))
                {
                    auxPasajero = pasajero;
                }
            }
            return auxPasajero;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            this.auxPasajero = this.SeleccionarPasajero(indice);
        }
    }
}
