
namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    partial class FormInternoBienvenido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.pictureMancha = new System.Windows.Forms.PictureBox();
            this.pictureFotoPerfil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMancha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Trueno", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.labelBienvenido.Location = new System.Drawing.Point(29, 29);
            this.labelBienvenido.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(437, 77);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "¡Bienvenido!";
            // 
            // pictureMancha
            // 
            this.pictureMancha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMancha.Image = global::PARCIAL_01_PEREZCARDENAL.PATRICIO_.Properties.Resources.MANCHA_DECORACION2;
            this.pictureMancha.Location = new System.Drawing.Point(437, 109);
            this.pictureMancha.Name = "pictureMancha";
            this.pictureMancha.Size = new System.Drawing.Size(802, 533);
            this.pictureMancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMancha.TabIndex = 1;
            this.pictureMancha.TabStop = false;
            // 
            // pictureFotoPerfil
            // 
            this.pictureFotoPerfil.Image = global::PARCIAL_01_PEREZCARDENAL.PATRICIO_.Properties.Resources.FOTOPERFIL_P4TTT0;
            this.pictureFotoPerfil.Location = new System.Drawing.Point(44, 129);
            this.pictureFotoPerfil.Margin = new System.Windows.Forms.Padding(35, 120, 3, 3);
            this.pictureFotoPerfil.Name = "pictureFotoPerfil";
            this.pictureFotoPerfil.Size = new System.Drawing.Size(219, 215);
            this.pictureFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFotoPerfil.TabIndex = 2;
            this.pictureFotoPerfil.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.pictureBox1.Location = new System.Drawing.Point(44, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 10);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.labelUsuario.Location = new System.Drawing.Point(276, 129);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(10, 120, 3, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(164, 42);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuario.";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.labelFecha.Location = new System.Drawing.Point(281, 179);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(15, 170, 3, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(90, 29);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha.";
            // 
            // FormInternoBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureFotoPerfil);
            this.Controls.Add(this.pictureMancha);
            this.Controls.Add(this.labelBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInternoBienvenido";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormInternoBienvenido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMancha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.PictureBox pictureMancha;
        private System.Windows.Forms.PictureBox pictureFotoPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelFecha;
    }
}