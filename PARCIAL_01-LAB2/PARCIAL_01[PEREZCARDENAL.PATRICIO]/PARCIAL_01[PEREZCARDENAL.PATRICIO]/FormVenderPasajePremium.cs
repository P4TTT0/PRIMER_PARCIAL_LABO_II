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
    public partial class FormVenderPasajePremium : FormVenderPasaje
    {
        private Viaje viaje;
        public FormVenderPasajePremium()
        {
            InitializeComponent();
        }
        public FormVenderPasajePremium(Viaje viaje) : this()
        {
            this.viaje = viaje;
        }


        private void FormVenderPasajePremium_Load(object sender, EventArgs e)
        {
            this.labelValorPrecioBruto.Text = $"{viaje.ValorPremium:c}";
            this.labelValorPrecioFinal.Text = $"{viaje.ValorFinalPremium:c}";
            this.AñadirCantidadEquipaje(2);
            this.checkPremium.Checked = true;
        }
    }
}
