﻿
namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    partial class FormVenderPasajeTurista
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
        private new void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.Items.AddRange(new object[] {
            Sexo.Hombre,
            Sexo.Mujer,
            Sexo.Otro});
            this.comboBoxSexo.Size = new System.Drawing.Size(184, 27);
            // 
            // comboBoxCantidadEquipaje
            // 
            this.comboBoxCantidadEquipaje.Size = new System.Drawing.Size(184, 27);
            // 
            // btnTipoPasaje
            // 
            this.btnTipoPasaje.FlatAppearance.BorderSize = 0;
            this.btnTipoPasaje.Location = new System.Drawing.Point(533, 12);
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.Items.AddRange(new object[] {
            Nacionalidad.Argentina,
            Nacionalidad.Paraguaya,
            Nacionalidad.Chilena,
            Nacionalidad.Uruguaya,
            Nacionalidad.Boliviana,
            Nacionalidad.Venezolana});
            // 
            // FormVenderPasajeTurista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 449);
            this.Name = "FormVenderPasajeTurista";
            this.Text = "VENDER PASAJE TURISTA";
            this.Load += new System.EventHandler(this.FormVenderPasajeTurista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}