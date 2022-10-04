using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    public partial class FormInternoBienvenido : Form
    {
        public FormInternoBienvenido()
        {
            InitializeComponent();
        }

        private void FormInternoBienvenido_Load(object sender, EventArgs e)
        {
            this.pictureMancha.SendToBack();
            this.labelUsuario.Text = FormLogin.UsuarioActual;
            this.labelFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
