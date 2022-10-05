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
    public partial class FormVisualizarViajes : Form
    {
        private int contador = 0;
        private List<Viaje> viajesEnCrucero;

        public FormVisualizarViajes()
        {
            InitializeComponent();

            this.ActualizarCrucero();
            this.ActualizarBotones();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.ActualizarCrucero(1);
            this.ActualizarBotones();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.ActualizarCrucero(0);
            this.ActualizarBotones();
        }

        private void ActualizarCrucero()
        {

            this.labelNombreBarco.Text = BaseDatos.cruceros[this.contador].Nombre;
            this.labelDigitosMatricula.Text = BaseDatos.cruceros[this.contador].Matricula;
            this.labelCantidadCamarotes.Text = BaseDatos.cruceros[this.contador].Camarotes.ToString();
            this.labelCantidadPiscinas.Text = BaseDatos.cruceros[this.contador].Piscinas.ToString();
            this.labelCantidadSalones.Text = BaseDatos.cruceros[this.contador].Salones.ToString();
            this.labelCantidadCasinos.Text = BaseDatos.cruceros[this.contador].Casinos.ToString();
            BaseDatos.cruceros[this.contador].TieneViajeAsignado = BaseDatos.ComprobarViajeEnCrucero(BaseDatos.cruceros[this.contador], out this.viajesEnCrucero);
            this.labelNumeroBarco.Text = (this.contador + 1).ToString();

            if (BaseDatos.cruceros[this.contador].TieneViajeAsignado)
            {
                this.btnViajeAsignado.BackColor = Color.FromArgb(125, 236, 167);
                this.btnViajeAsignado.Text = "CON VIAJE";              
            }
            else
            {
                this.btnViajeAsignado.BackColor = Color.FromArgb(255, 192, 192);
                this.btnViajeAsignado.Text = "SIN VIAJE";
            }
        }

        private void ActualizarCrucero(int boton)
        {
            if (boton == 1)
            {
                this.contador++;
            }
            else
            {
                this.contador--;
            }

            if (contador == BaseDatos.cruceros.Count)
            {
                this.contador = 0;
            }
            else
            {
                if (contador == -1)
                {
                    this.contador = BaseDatos.cruceros.Count - 1;
                }
            }

            this.ActualizarCrucero();
        }

        private void ActualizarBotones()
        {
            if (BaseDatos.cruceros[this.contador].TieneViajeAsignado)
            {
                this.btnVerViaje.Enabled = true;
            }
            else
            {
                this.btnVerViaje.Enabled = false;
            }
        }

        private void btnVerViaje_Click(object sender, EventArgs e)
        {
            if (BaseDatos.cruceros[this.contador].TieneViajeAsignado)
            {
                FormMostrarInformarcion formInfo = new FormMostrarInformarcion(this.viajesEnCrucero);
                formInfo.ShowDialog();
            }
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            FormCrearViaje formCrear = new FormCrearViaje(this.viajesEnCrucero);

            if (formCrear.ShowDialog() == DialogResult.OK)
            {
                if (formCrear.Destino == 1)
                {
                    BaseDatos.viajes.Add(new Viaje(formCrear.FechaIncio, BaseDatos.cruceros[this.contador], formCrear.DestinoExtraRegional));
                }
                else
                {
                    BaseDatos.viajes.Add(new Viaje(formCrear.FechaIncio, BaseDatos.cruceros[this.contador], formCrear.DestinoRegional));
                }
                this.ActualizarCrucero();
                this.ActualizarBotones();
                BaseDatos.ActualizarLeaderboardCrucero();
            }
        }
    }
}
