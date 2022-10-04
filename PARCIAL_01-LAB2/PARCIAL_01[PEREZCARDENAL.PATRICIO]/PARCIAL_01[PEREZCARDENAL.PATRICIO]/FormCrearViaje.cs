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
    public partial class FormCrearViaje : Form
    {
        private List<Viaje> viajes = new List<Viaje>();
        private DateTime fechaIncio;
        private ViajesRegionales destinoRegional;
        private ViajesExtraRegionales destinoExtraRegional;
        private int destino;

        public DateTime FechaIncio { get => fechaIncio; }
        public ViajesRegionales DestinoRegional { get => destinoRegional; }
        public ViajesExtraRegionales DestinoExtraRegional { get => destinoExtraRegional; }
        public int Destino { get => destino; }

        public FormCrearViaje()
        {
            InitializeComponent();
        }

        public FormCrearViaje(List<Viaje> viajes) : this()
        {
            this.viajes = viajes;
        }

        private void FormCrearViaje_Load(object sender, EventArgs e)
        {
            this.pictureMancha.SendToBack();
            this.ActualizarDestino();
            this.ActualizarMinDate();
            this.pictureSimboloError.Visible = false;
            this.labelErrorDestino.Visible = false;
            this.labelErrorFecha.Visible = false;
            this.pictureErrorFecha.Visible = false;
        }

        private void ActualizarDestino()
        {
            this.comboBoxDestino.Items.Clear();

            if (radioBtnRegional.Checked == true)
            {
                foreach (ViajesRegionales item in Enum.GetValues(typeof(ViajesRegionales)))
                {
                    this.comboBoxDestino.Items.Add(item);
                }
            }
            else
            {
                foreach (ViajesExtraRegionales item in Enum.GetValues(typeof(ViajesExtraRegionales)))
                {
                    this.comboBoxDestino.Items.Add(item);
                }
            }
        }

        private void radioBtnRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarDestino();
        }

        private void radioBtnExtraRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarDestino();
        }

        private void ActualizarMinDate()
        {
            this.dateTimePicker.MinDate = DateTime.Now;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!(this.ValidarFecha(this.dateTimePicker.Value)) && !(this.ValidarItemSeleccionado()) )
            {
                if (this.radioBtnExtraRegional.Checked == true)
                {
                    this.destino = 1;
                    this.destinoExtraRegional = (ViajesExtraRegionales)this.comboBoxDestino.SelectedItem;
                }
                else
                {
                    this.destino = 0;
                    this.destinoRegional = (ViajesRegionales)this.comboBoxDestino.SelectedItem;
                }
                this.fechaIncio = this.dateTimePicker.Value;
                this.DialogResult = DialogResult.OK;
            }           
        }

        private bool ValidarFecha(DateTime fechaSeleccionada)
        {
            bool validacion = false;
            if (this.viajes.Count > 0)
            {
                foreach (Viaje viaje in this.viajes)
                {
                    if ((fechaSeleccionada > viaje.FechaInicioViaje && fechaSeleccionada < viaje.FechaFinalViaje) || (fechaSeleccionada.AddDays(30) > viaje.FechaInicioViaje && fechaSeleccionada.AddDays(30) < viaje.FechaFinalViaje))
                    {
                        validacion = true;
                        this.MostrarErrorDuracionViaje();
                        break;
                    }
                }
            }
            return validacion;
        }

        private bool ValidarItemSeleccionado()
        {
            bool validacion = false;
            if (this.comboBoxDestino.SelectedItem == null)
            {
                validacion = true;
                this.pictureSimboloError.Visible = true;
                this.labelErrorDestino.Visible = true;
            }

            return validacion;
        }

        private void MostrarErrorDuracionViaje()
        {
            this.labelErrorFecha.Visible = true;
            this.pictureErrorFecha.Visible = true;
        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureSimboloError.Visible = false;
            this.labelErrorDestino.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.labelErrorFecha.Visible = false;
            this.pictureErrorFecha.Visible = false;
        }
    }
}
