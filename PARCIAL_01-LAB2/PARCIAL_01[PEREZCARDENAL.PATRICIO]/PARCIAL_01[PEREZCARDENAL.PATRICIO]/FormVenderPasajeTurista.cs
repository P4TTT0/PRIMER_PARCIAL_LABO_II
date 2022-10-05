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
    public partial class FormVenderPasajeTurista : FormVenderPasaje
    {
        private Viaje viaje;
        public FormVenderPasajeTurista() 
        {
            InitializeComponent();
        }
        public FormVenderPasajeTurista(Viaje viaje) : this()
        {
            this.viaje = viaje;
        }
        private void FormVenderPasajeTurista_Load(object sender, EventArgs e)
        {
            this.labelValorPrecioBruto.Text = $"{viaje.ValorTurista:c}";
            this.labelValorPrecioFinal.Text = $"{viaje.ValorFinalTurista:c}";
            this.AñadirCantidadEquipaje(1);
            this.btnTipoPasaje.Text = "TURISTA";
            this.btnTipoPasaje.BackColor = Color.FromArgb(105, 123, 175);
        }
    }
}
