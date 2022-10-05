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
    public partial class FormMostrarInformarcion : Form
    {
        private int contador;
        List<Viaje> viajes;
        private DateTime hoy = DateTime.Today;
        public FormMostrarInformarcion()
        {
            InitializeComponent();
        }

        public FormMostrarInformarcion(List<Viaje> viajes) : this()
        {
            this.viajes = viajes;
            this.ActualizarViaje();
        }

        private void ActualizarViaje()
        {
            this.viajes[this.contador].CalcularDisponibilidadPasajes();
            this.labelInfoDestino.Text = this.viajes[this.contador].Destino;
            this.labelCantidadCamarotesPremium.Text = this.viajes[this.contador].CamarotesPremium.ToString();
            this.labelCantidadCamarotesTurista.Text = this.viajes[this.contador].CamarotesTurista.ToString();
            this.labelValorPrecioPremium.Text = $"{this.viajes[this.contador].ValorPremium:c}";
            this.labelValorPrecioTurista.Text = $"{this.viajes[this.contador].ValorTurista:c}";
            this.labelHorasDuracion.Text = $"{this.viajes[this.contador].DuracionViaje.ToString()}" + " HS."; 
            this.labelMaxCantidadPasajeros.Text = this.viajes[this.contador].MaxCantidadPasajeros.ToString();
            this.labelCantidadPasajesLibres.Text = $"{this.viajes[this.contador].DisponibilidadPasajes}";
            this.labelCapacidadBodegaValor.Text = $"{this.viajes[this.contador].Crucero.Bodega}" + " KG.";
            this.labelInfoFechaInicio.Text = $"{this.viajes[this.contador].FechaInicioViaje:d}";
            this.labelInfoFechaFinal.Text = $"{this.viajes[this.contador].FechaFinalViaje:d}";
            this.ActualizarEstadoViaje();
        }

        private void ActualizarViaje(int boton)
        {
            if (boton == 1)
            {
                this.contador++;
            }
            else
            {
                this.contador--;
            }

            if (this.contador == this.viajes.Count)
            {
                this.contador = 0;
            }
            else
            {
                if (this.contador == -1)
                {
                    this.contador = this.viajes.Count - 1;
                }
            }

            this.ActualizarViaje();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.ActualizarViaje(0);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.ActualizarViaje(1);
        }

        private void FormMostrarInformarcion_Load(object sender, EventArgs e)
        {
            if (this.viajes.Count == 1)
            {
                this.btnSiguiente.Enabled = false;
                this.btnAnterior.Enabled = false;
            }
        }

        private void ActualizarEstadoViaje()
        {
            switch(this.viajes[this.contador].EstadoViaje)
            {
                case EstadoViaje.ESPERANDO:
                    this.btnEstadoViaje.Text = "ESPERANDO";
                    this.btnEstadoViaje.BackColor = Color.FromArgb(242, 248, 153);
                    break;

                case EstadoViaje.EN_VIAJE:
                    this.btnEstadoViaje.Text = "EN VIAJE";
                    this.btnEstadoViaje.BackColor = Color.FromArgb(153, 248, 162);
                    break;

                case EstadoViaje.FINALIZADO:
                    this.btnEstadoViaje.Text = "FINALIZADO";
                    this.btnEstadoViaje.BackColor = Color.FromArgb(248, 153, 153);
                    break;
            }        
        }
    }
}
