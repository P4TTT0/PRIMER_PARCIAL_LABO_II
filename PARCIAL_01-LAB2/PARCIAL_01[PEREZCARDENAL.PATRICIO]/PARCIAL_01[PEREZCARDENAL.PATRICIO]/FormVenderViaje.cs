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
    public partial class FormVenderViaje : Form
    {
        private int contador = 0;
        private List<Viaje> viajes = new List<Viaje>();
        public FormVenderViaje()
        {
            InitializeComponent();
            this.pictureMancha.SendToBack();
            this.ClonarListaCompletaViajes();
        }

        private void ActualizarViaje()
        {
            this.viajes[this.contador].CalcularDisponibilidadPasajes();
            this.labelNombreCrucero.Text = this.viajes[this.contador].Crucero.Nombre;
            this.labelInfoDestino.Text = this.viajes[this.contador].Destino;
            this.labelCantidadDisponibilidad.Text = $"{this.viajes[this.contador].DisponibilidadPasajes}";
            this.labelCantidadPiscina.Text = this.viajes[this.contador].Crucero.Piscinas.ToString();
            this.labelCantidadCasino.Text = this.viajes[this.contador].Crucero.Casinos.ToString();
            this.ActualizarCasinos();
            this.ActualizarPiscinas();
            this.ActualizarEstadoViaje();
            this.labelCantidadViajes.Text = this.viajes.Count.ToString();
            this.labelNumeroViajeActual.Text = (contador + 1).ToString();
            this.ActualizarBotonesVentas();
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.ActualizarViaje(1);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.ActualizarViaje(0);
        }

        private void FormVenderViaje_Load(object sender, EventArgs e)
        {
            this.ActualizarViaje();
        }

        private void ActualizarPiscinas()
        {
            if (this.viajes[this.contador].Crucero.Piscinas > 0)
            {
                this.btnPiscina.Text = "SI PISCINA";
                this.btnPiscina.BackColor = Color.FromArgb(125, 236, 167);
            }
            else
            {
                this.btnPiscina.Text = "NO PISCINA";
                this.btnPiscina.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        private void ActualizarCasinos()
        {
            if (this.viajes[this.contador].Crucero.Casinos > 0)
            {
                this.btnCasino.Text = "SI CASINO";
                this.btnCasino.BackColor = Color.FromArgb(125, 236, 167);
            }
            else
            {
                this.btnCasino.Text = "NO CASINO";
                this.btnCasino.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        private void filtrarPiscinas()
        {
            this.viajes.Clear();
            this.contador = 0;
            foreach (Viaje viaje in BaseDatos.viajes)
            {
                if (viaje.EstadoViaje == EstadoViaje.ESPERANDO && viaje.Crucero.Piscinas > 0)
                {
                    this.viajes.Add(viaje);
                }
            }
        }

        private void FiltrarCasinos()
        {
            this.viajes.Clear();
            this.contador = 0;
            foreach (Viaje viaje in BaseDatos.viajes)
            {
                if (viaje.EstadoViaje == EstadoViaje.ESPERANDO && viaje.Crucero.Casinos > 0)
                {
                    this.viajes.Add(viaje);
                }
            }
        }

        private void ClonarListaCompletaViajes()
        {
            this.viajes.Clear();
            this.contador = 0;
            foreach (Viaje viaje in BaseDatos.viajes)
            {
                this.viajes.Add(viaje);       
            }
        }

        private void radioBtnPiscina_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBtnPiscina.Checked == true)
            {
                this.filtrarPiscinas();
                this.ActualizarViaje();
            }
        }

        private void radioBtnCasino_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBtnCasino.Checked == true)
            {
                this.FiltrarCasinos();
                this.ActualizarViaje();
            }
        }

        private void radioBtnSinFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBtnSinFiltro.Checked == true)
            {
                this.ClonarListaCompletaViajes();
                this.ActualizarViaje();
            }
        }

        private void ActualizarEstadoViaje()
        {
            switch (this.viajes[this.contador].EstadoViaje)
            {
                case EstadoViaje.ESPERANDO:
                    this.btnEstado.Text = "ESPERANDO";
                    this.btnEstado.BackColor = Color.FromArgb(242, 248, 153);
                    break;

                case EstadoViaje.EN_VIAJE:
                    this.btnEstado.Text = "EN VIAJE";
                    this.btnEstado.BackColor = Color.FromArgb(153, 248, 162);
                    break;

                case EstadoViaje.FINALIZADO:
                    this.btnEstado.Text = "FINALIZADO";
                    this.btnEstado.BackColor = Color.FromArgb(248, 153, 153);
                    break;
            }
        }

        private void ActualizarBotonesVentas()
        {
            if (this.viajes[this.contador].EstadoViaje != EstadoViaje.ESPERANDO)
            {
                this.btnVenderPasaje.Enabled = false;
                this.btnVenderTurista.Enabled = false;
            }
            else
            {
                this.btnVenderPasaje.Enabled = true;
                this.btnVenderTurista.Enabled = true;
            }
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            FormVenderPasajePremium formVender = new FormVenderPasajePremium(this.viajes[this.contador]);
            if (formVender.ShowDialog() == DialogResult.OK)
            {
               if (!Pasaporte.ValidarDni(formVender.Dni, this.viajes[this.contador]))
                {
                    this.viajes[this.contador] += formVender.AuxPasajero;
                    if (this.viajes[this.contador].ComprobarDestinoEsRegional(this.viajes[this.contador].Destino))
                    {
                        BaseDatos.ActualizarGananciaRegional(this.viajes[this.contador].ValorFinalTurista);
                    }
                    else
                    {
                        BaseDatos.ActualizarGananciaExtraRegional(this.viajes[this.contador].ValorFinalTurista);
                    }
                    this.ActualizarViaje();
                    MessageBox.Show("¡Cargado correctamente!", "Pasajero cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡No se pudo cargar el pasajero ya que ya se encuentra en este viaje!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVenderTurista_Click(object sender, EventArgs e)
        {
            FormVenderPasajeTurista formVender = new FormVenderPasajeTurista(this.viajes[this.contador]);
            if (formVender.ShowDialog() == DialogResult.OK)
            {
                if (!Pasaporte.ValidarDni(formVender.Dni, this.viajes[this.contador]))
                {
                    this.viajes[this.contador] += formVender.AuxPasajero;
                    if (this.viajes[this.contador].ComprobarDestinoEsRegional(this.viajes[this.contador].Destino))
                    {
                        BaseDatos.ActualizarGananciaRegional(this.viajes[this.contador].ValorFinalTurista);
                    }
                    else
                    {
                        BaseDatos.ActualizarGananciaExtraRegional(this.viajes[this.contador].ValorFinalTurista);
                    }
                    this.ActualizarViaje();
                    MessageBox.Show("¡Cargado correctamente!", "Pasajero cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡No se pudo cargar el pasajero ya que ya se encuentra en este viaje!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
