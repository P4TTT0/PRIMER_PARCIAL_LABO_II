
namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    partial class FormCrearViaje
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
            this.radioBtnRegional = new System.Windows.Forms.RadioButton();
            this.radioBtnExtraRegional = new System.Windows.Forms.RadioButton();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelSeleccionarFecha = new System.Windows.Forms.Label();
            this.labelSeleccionDestino = new System.Windows.Forms.Label();
            this.pictureMancha = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureSimboloError = new System.Windows.Forms.PictureBox();
            this.labelErrorDestino = new System.Windows.Forms.Label();
            this.labelErrorFecha = new System.Windows.Forms.Label();
            this.pictureErrorFecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMancha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimboloError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureErrorFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnRegional
            // 
            this.radioBtnRegional.AutoSize = true;
            this.radioBtnRegional.Font = new System.Drawing.Font("Trueno", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnRegional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnRegional.Location = new System.Drawing.Point(14, 46);
            this.radioBtnRegional.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.radioBtnRegional.Name = "radioBtnRegional";
            this.radioBtnRegional.Size = new System.Drawing.Size(131, 27);
            this.radioBtnRegional.TabIndex = 0;
            this.radioBtnRegional.TabStop = true;
            this.radioBtnRegional.Text = "REGIONAL";
            this.radioBtnRegional.UseVisualStyleBackColor = true;
            this.radioBtnRegional.CheckedChanged += new System.EventHandler(this.radioBtnRegional_CheckedChanged);
            // 
            // radioBtnExtraRegional
            // 
            this.radioBtnExtraRegional.AutoSize = true;
            this.radioBtnExtraRegional.Font = new System.Drawing.Font("Trueno", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnExtraRegional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnExtraRegional.Location = new System.Drawing.Point(12, 79);
            this.radioBtnExtraRegional.Name = "radioBtnExtraRegional";
            this.radioBtnExtraRegional.Size = new System.Drawing.Size(203, 27);
            this.radioBtnExtraRegional.TabIndex = 1;
            this.radioBtnExtraRegional.TabStop = true;
            this.radioBtnExtraRegional.Text = "EXTRA REGIONAL";
            this.radioBtnExtraRegional.UseVisualStyleBackColor = true;
            this.radioBtnExtraRegional.CheckedChanged += new System.EventHandler(this.radioBtnExtraRegional_CheckedChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDestino.Font = new System.Drawing.Font("Trueno", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(14, 112);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(295, 24);
            this.comboBoxDestino.TabIndex = 2;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Trueno", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(14, 208);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(295, 22);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelSeleccionarFecha
            // 
            this.labelSeleccionarFecha.AutoSize = true;
            this.labelSeleccionarFecha.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSeleccionarFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.labelSeleccionarFecha.Location = new System.Drawing.Point(12, 176);
            this.labelSeleccionarFecha.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.labelSeleccionarFecha.Name = "labelSeleccionarFecha";
            this.labelSeleccionarFecha.Size = new System.Drawing.Size(272, 29);
            this.labelSeleccionarFecha.TabIndex = 4;
            this.labelSeleccionarFecha.Text = "Seleccione una fecha:";
            // 
            // labelSeleccionDestino
            // 
            this.labelSeleccionDestino.AutoSize = true;
            this.labelSeleccionDestino.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSeleccionDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.labelSeleccionDestino.Location = new System.Drawing.Point(14, 14);
            this.labelSeleccionDestino.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.labelSeleccionDestino.Name = "labelSeleccionDestino";
            this.labelSeleccionDestino.Size = new System.Drawing.Size(282, 29);
            this.labelSeleccionDestino.TabIndex = 5;
            this.labelSeleccionDestino.Text = "Seleccione un destino:";
            // 
            // pictureMancha
            // 
            this.pictureMancha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMancha.BackColor = System.Drawing.Color.Transparent;
            this.pictureMancha.Image = global::PARCIAL_01_PEREZCARDENAL.PATRICIO_.Properties.Resources.MANCHA_DECORACION2;
            this.pictureMancha.Location = new System.Drawing.Point(212, 160);
            this.pictureMancha.Name = "pictureMancha";
            this.pictureMancha.Size = new System.Drawing.Size(392, 296);
            this.pictureMancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMancha.TabIndex = 6;
            this.pictureMancha.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Trueno", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnCrear.Location = new System.Drawing.Point(372, 387);
            this.btnCrear.MaximumSize = new System.Drawing.Size(215, 47);
            this.btnCrear.MinimumSize = new System.Drawing.Size(134, 47);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 47);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "CREAR VIAJE";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trueno", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(12, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 47);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureSimboloError
            // 
            this.pictureSimboloError.Image = global::PARCIAL_01_PEREZCARDENAL.PATRICIO_.Properties.Resources.EXCLAMACION_ERROR;
            this.pictureSimboloError.Location = new System.Drawing.Point(14, 144);
            this.pictureSimboloError.Name = "pictureSimboloError";
            this.pictureSimboloError.Size = new System.Drawing.Size(18, 18);
            this.pictureSimboloError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSimboloError.TabIndex = 9;
            this.pictureSimboloError.TabStop = false;
            // 
            // labelErrorDestino
            // 
            this.labelErrorDestino.AutoSize = true;
            this.labelErrorDestino.Font = new System.Drawing.Font("Trueno", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErrorDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelErrorDestino.Location = new System.Drawing.Point(38, 148);
            this.labelErrorDestino.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelErrorDestino.Name = "labelErrorDestino";
            this.labelErrorDestino.Size = new System.Drawing.Size(180, 13);
            this.labelErrorDestino.TabIndex = 10;
            this.labelErrorDestino.Text = "¡Debes seleccionar un destino!";
            // 
            // labelErrorFecha
            // 
            this.labelErrorFecha.AutoSize = true;
            this.labelErrorFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorFecha.Font = new System.Drawing.Font("Trueno", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErrorFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelErrorFecha.Location = new System.Drawing.Point(38, 242);
            this.labelErrorFecha.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelErrorFecha.Name = "labelErrorFecha";
            this.labelErrorFecha.Size = new System.Drawing.Size(305, 13);
            this.labelErrorFecha.TabIndex = 12;
            this.labelErrorFecha.Text = "¡La fecha puede estar pisando la fecha de otro viaje!";
            // 
            // pictureErrorFecha
            // 
            this.pictureErrorFecha.Image = global::PARCIAL_01_PEREZCARDENAL.PATRICIO_.Properties.Resources.EXCLAMACION_ERROR;
            this.pictureErrorFecha.Location = new System.Drawing.Point(14, 238);
            this.pictureErrorFecha.Name = "pictureErrorFecha";
            this.pictureErrorFecha.Size = new System.Drawing.Size(18, 18);
            this.pictureErrorFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureErrorFecha.TabIndex = 11;
            this.pictureErrorFecha.TabStop = false;
            // 
            // FormCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(546, 446);
            this.Controls.Add(this.labelErrorFecha);
            this.Controls.Add(this.pictureErrorFecha);
            this.Controls.Add(this.labelErrorDestino);
            this.Controls.Add(this.pictureSimboloError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pictureMancha);
            this.Controls.Add(this.labelSeleccionDestino);
            this.Controls.Add(this.labelSeleccionarFecha);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.radioBtnExtraRegional);
            this.Controls.Add(this.radioBtnRegional);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MaximumSize = new System.Drawing.Size(562, 485);
            this.MinimumSize = new System.Drawing.Size(365, 439);
            this.Name = "FormCrearViaje";
            this.Text = "CREAR VIAJE";
            this.Load += new System.EventHandler(this.FormCrearViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMancha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimboloError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureErrorFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnRegional;
        private System.Windows.Forms.RadioButton radioBtnExtraRegional;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelSeleccionarFecha;
        private System.Windows.Forms.Label labelSeleccionDestino;
        private System.Windows.Forms.PictureBox pictureMancha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureSimboloError;
        private System.Windows.Forms.Label labelErrorDestino;
        private System.Windows.Forms.Label labelErrorFecha;
        private System.Windows.Forms.PictureBox pictureErrorFecha;
    }
}