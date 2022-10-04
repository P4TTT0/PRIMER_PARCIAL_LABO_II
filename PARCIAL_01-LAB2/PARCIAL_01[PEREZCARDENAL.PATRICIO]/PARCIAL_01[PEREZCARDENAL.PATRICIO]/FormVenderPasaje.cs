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
    public partial class FormVenderPasaje : Form
    {
        protected Pasajero auxPasajero;
        protected int dni;

        public Pasajero AuxPasajero { get => auxPasajero; }
        public int Dni { get => dni; set => dni = value; }

        public FormVenderPasaje()
        {
            InitializeComponent();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPesoEquipaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FormVenderPasaje_Load(object sender, EventArgs e)
        {
            this.ActualizarErrorCamposVacios(0);
            this.ActualizarErrorDniCargado(0);
            this.ActualizarErrorPasaporteCargado(0);
            this.CargarGeneros();
            this.CargarNacionalidades();
        }

        private bool ValidarCamposLlenos()
        {
            bool validacion = false;
            foreach (Control control in groupBoxContenedor.Controls)
            {
                if (control is TextBox textBox && textBox.Text == String.Empty)
                {
                    this.ActualizarErrorCamposVacios(1);
                    validacion = true;
                    break;
                }
                if (control is ComboBox comboBox && comboBox.SelectedItem == null)
                {
                    this.ActualizarErrorCamposVacios(1);
                    validacion = true;
                    break;
                }
            }
            return validacion;
        }

        private void ActualizarErrorCamposVacios(int opcion)
        {
            if (opcion == 1)
            {
                this.pictureErrorCamposVacios.Visible = true;
                this.labelErrorCamposVacios.Visible = true;
            }
            else
            {
                this.pictureErrorCamposVacios.Visible = false;
                this.labelErrorCamposVacios.Visible = false;
            }
        }

        private void ActualizarErrorDniCargado(int opcion)
        {
            if (opcion == 1)
            {
                this.pictureErrorDniCargado.Visible = true;
                this.labelErrorDniCargado.Visible = true;
            }
            else
            {
                this.pictureErrorDniCargado.Visible = false;
                this.labelErrorDniCargado.Visible = false;
            }
        }

        private void ActualizarErrorPasaporteCargado(int opcion)
        {
            if (opcion == 1)
            {
                this.pictureErrorPasaporteCargado.Visible = true;
                this.labelErrorPasaporteCargado.Visible = true;
            }
            else
            {
                this.pictureErrorPasaporteCargado.Visible = false;
                this.labelErrorPasaporteCargado.Visible = false;
            }
        }

        private void ActualizarMaximoPesoEquipaje()
        {
            if (this.comboBoxCantidadEquipaje.SelectedIndex == 0)
            {
                this.numericPesoEquipaje.Maximum = 25;
            }
            else
            {
                this.numericPesoEquipaje.Maximum = 50;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {      
            if (this.textBoxDni.Text != String.Empty)
            {
                if (!this.ValidarCamposLlenos())
                {
                    this.auxPasajero = new Pasajero(this.textBoxNombre.Text, this.textBoxApellido.Text, int.Parse(this.textBoxEdad.Text), 
                                                    (Sexo)this.comboBoxSexo.SelectedItem, int.Parse(this.textBoxDni.Text), int.Parse(this.textBoxNumeroPasaporte.Text), 
                                                    (Nacionalidad)this.comboBoxNacionalidad.SelectedItem, this.checkBoxTieneEquipajeMano.Checked, (int)this.comboBoxCantidadEquipaje.SelectedItem, (int)this.numericPesoEquipaje.Value, 
                                                    this.checkPremium.Checked);
                    this.dni = int.Parse(this.textBoxDni.Text);
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void CargarNacionalidades()
        {
            this.comboBoxNacionalidad.Items.Clear();
            foreach (Nacionalidad nacionalidad in Enum.GetValues(typeof(Nacionalidad)))
            {
                this.comboBoxNacionalidad.Items.Add(nacionalidad);
            }
        }

        private void CargarGeneros()
        {
            this.comboBoxSexo.Items.Clear();
            foreach (Sexo genero in Enum.GetValues(typeof(Sexo)))
            {
                this.comboBoxSexo.Items.Add(genero);
            }
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            this.ActualizarErrorDniCargado(0);
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumeroPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBoxCantidadEquipaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarMaximoPesoEquipaje();
        }

        protected void AñadirCantidadEquipaje(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                this.comboBoxCantidadEquipaje.Items.Add(i + 1);
            }
        }
    }
}
