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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.WindowState = FormWindowState.Normal;
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormInterno(Form formInterno)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            formInterno.TopLevel = false; //No es un form de nivel superior, es un form secundario.
            formInterno.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formInterno);
            this.panelContenedor.Tag = formInterno;
            formInterno.Show();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FormVisualizarViajes());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FormInternoBienvenido());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FormInternoBienvenido());
            BaseDatos.RecogerGananciasHistoricas();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FormVenderViaje());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FormMostrarPasajeros());
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.AbrirFormInterno(new FormEstadisticas());
        }
    }
}
