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
    public partial class FormInfoDetalladaPasajero : Form
    {
        private Pasajero pasajero;
        public FormInfoDetalladaPasajero()
        {
            InitializeComponent();
        }
        
        public FormInfoDetalladaPasajero (Pasajero pasajero) : this()
        {
            this.pasajero = pasajero;
        }

        private void FormInfoDetalladaPasajero_Load(object sender, EventArgs e)
        {
            this.labelNombre.Text = pasajero.Nombre;
            this.labelApellido.Text = pasajero.Apellido;
            this.labelEdadValor.Text = pasajero.Edad.ToString();
            this.labelGeneroValor.Text = pasajero.Genero.ToString();
            this.labelDniValor.Text = pasajero.pasaporte.Dni.ToString();
            this.labelPasaporteValor.Text = pasajero.pasaporte.NumeroPasaporte.ToString();
            this.labelNacionalidadValor.Text = pasajero.pasaporte.Nacionalidad.ToString();
            this.labelCantidadValijasValor.Text = pasajero.equipaje.CantidadEquipaje.ToString();
            this.labelPesoValijasValor.Text = pasajero.equipaje.PesoEquipaje.ToString();

            this.ActualizarTipoPasaje();
            this.ActualizarBolsoDeMano();
        }

        private void ActualizarTipoPasaje()
        {
            if (!pasajero.EsPremium)
            {
                this.btnTuristaPremium.BackColor = Color.FromArgb(105, 123, 175);
                this.btnTuristaPremium.Text = "TURISTA";
            }
        }

        private void ActualizarBolsoDeMano()
        {
            if (pasajero.equipaje.EquipajeMano)
            {
                this.btnBolsoDeMano.BackColor = Color.FromArgb(125, 236, 167);
                this.btnBolsoDeMano.Text = "TIENE BOLSO DE MANO";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
