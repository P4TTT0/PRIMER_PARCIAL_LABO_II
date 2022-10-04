using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PARCIAL_01_BIBLIOTECA_;

namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.labelUsuarioInvalido.Visible = false;
            this.simboloUsuarioInvalido.Visible = false;
        }
        private static string usuarioActual;

        #region TEXTBOX USUARIO
        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "USUARIO")
            {
                textBoxUsuario.Text = "";
            }
            textBoxUsuario.ForeColor = Color.FromArgb(105, 123, 175);
            lineaUsuario.BackColor = Color.FromArgb(105, 123, 175);
        }
        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "USUARIO";
            }
        }

        #endregion
        #region TEXTBOX CONTRASEÑA
        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "CONTRASEÑA")
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.UseSystemPasswordChar = true;
            }
            textBoxContraseña.ForeColor = Color.FromArgb(105, 123, 175);
            lineaContraseña.BackColor = Color.FromArgb(105, 123, 175);
        }

        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                textBoxContraseña.Text = "CONTRASEÑA";
                textBoxContraseña.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region BOTON LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseDatos.ComprobarDatos(new Usuario(textBoxUsuario.Text, textBoxContraseña.Text)))
            {
                FormMenuPrincipal menu = new FormMenuPrincipal();
                usuarioActual = textBoxUsuario.Text;
                menu.Show();
                this.Hide();
            }
            else
            {
                UsuarioInvalido();
            }
              
        }
        #endregion

        private void UsuarioInvalido()
        {
            lineaContraseña.BackColor = Color.FromArgb(194, 32, 44);
            lineaUsuario.BackColor = Color.FromArgb(194, 32, 44);
            textBoxContraseña.ForeColor = Color.FromArgb(194, 32, 44);
            textBoxUsuario.ForeColor = Color.FromArgb(194, 32, 44);

            this.labelUsuarioInvalido.Visible = true;
            this.simboloUsuarioInvalido.Visible = true;
        }

        public static string UsuarioActual
        {
            get
            {
                return usuarioActual;
            }
        }
    }
}
