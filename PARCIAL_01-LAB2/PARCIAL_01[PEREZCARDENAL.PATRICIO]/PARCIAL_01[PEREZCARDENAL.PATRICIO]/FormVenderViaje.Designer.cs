
namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    partial class FormVenderViaje
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
            this.panelBeSide = new System.Windows.Forms.Panel();
            this.radioBtnSinFiltro = new System.Windows.Forms.RadioButton();
            this.radioBtnCasino = new System.Windows.Forms.RadioButton();
            this.radioBtnPiscina = new System.Windows.Forms.RadioButton();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.labelCrucero = new System.Windows.Forms.Label();
            this.labelNombreCrucero = new System.Windows.Forms.Label();
            this.labelInfoDestino = new System.Windows.Forms.Label();
            this.btnPiscina = new System.Windows.Forms.Button();
            this.btnCasino = new System.Windows.Forms.Button();
            this.labelDisponibilidad = new System.Windows.Forms.Label();
            this.pictureMancha = new System.Windows.Forms.PictureBox();
            this.labelCantidadDisponibilidad = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.labelCantidadPiscina = new System.Windows.Forms.Label();
            this.labelCantidadCasino = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelCantidadViajes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumeroViajeActual = new System.Windows.Forms.Label();
            this.labelViaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVenderPasaje = new System.Windows.Forms.Button();
            this.btnVenderTurista = new System.Windows.Forms.Button();
            this.panelBeSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMancha)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBeSide
            // 
            this.panelBeSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelBeSide.Controls.Add(this.radioBtnSinFiltro);
            this.panelBeSide.Controls.Add(this.radioBtnCasino);
            this.panelBeSide.Controls.Add(this.radioBtnPiscina);
            this.panelBeSide.Controls.Add(this.btnFiltros);
            this.panelBeSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBeSide.Location = new System.Drawing.Point(0, 0);
            this.panelBeSide.Name = "panelBeSide";
            this.panelBeSide.Size = new System.Drawing.Size(238, 628);
            this.panelBeSide.TabIndex = 0;
            // 
            // radioBtnSinFiltro
            // 
            this.radioBtnSinFiltro.AutoSize = true;
            this.radioBtnSinFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBtnSinFiltro.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSinFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnSinFiltro.Location = new System.Drawing.Point(0, 215);
            this.radioBtnSinFiltro.Name = "radioBtnSinFiltro";
            this.radioBtnSinFiltro.Padding = new System.Windows.Forms.Padding(35, 20, 35, 0);
            this.radioBtnSinFiltro.Size = new System.Drawing.Size(238, 53);
            this.radioBtnSinFiltro.TabIndex = 3;
            this.radioBtnSinFiltro.TabStop = true;
            this.radioBtnSinFiltro.Text = "Sin filtro";
            this.radioBtnSinFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnSinFiltro.UseVisualStyleBackColor = true;
            this.radioBtnSinFiltro.CheckedChanged += new System.EventHandler(this.radioBtnSinFiltro_CheckedChanged);
            // 
            // radioBtnCasino
            // 
            this.radioBtnCasino.AutoSize = true;
            this.radioBtnCasino.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBtnCasino.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnCasino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnCasino.Location = new System.Drawing.Point(0, 162);
            this.radioBtnCasino.Name = "radioBtnCasino";
            this.radioBtnCasino.Padding = new System.Windows.Forms.Padding(35, 20, 35, 0);
            this.radioBtnCasino.Size = new System.Drawing.Size(238, 53);
            this.radioBtnCasino.TabIndex = 2;
            this.radioBtnCasino.TabStop = true;
            this.radioBtnCasino.Text = "Casino";
            this.radioBtnCasino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnCasino.UseVisualStyleBackColor = true;
            this.radioBtnCasino.CheckedChanged += new System.EventHandler(this.radioBtnCasino_CheckedChanged);
            // 
            // radioBtnPiscina
            // 
            this.radioBtnPiscina.AutoSize = true;
            this.radioBtnPiscina.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBtnPiscina.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnPiscina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnPiscina.Location = new System.Drawing.Point(0, 109);
            this.radioBtnPiscina.Name = "radioBtnPiscina";
            this.radioBtnPiscina.Padding = new System.Windows.Forms.Padding(35, 20, 35, 0);
            this.radioBtnPiscina.Size = new System.Drawing.Size(238, 53);
            this.radioBtnPiscina.TabIndex = 1;
            this.radioBtnPiscina.TabStop = true;
            this.radioBtnPiscina.Text = "Piscina";
            this.radioBtnPiscina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnPiscina.UseVisualStyleBackColor = true;
            this.radioBtnPiscina.CheckedChanged += new System.EventHandler(this.radioBtnPiscina_CheckedChanged);
            // 
            // btnFiltros
            // 
            this.btnFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.btnFiltros.FlatAppearance.BorderSize = 0;
            this.btnFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.btnFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltros.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnFiltros.Location = new System.Drawing.Point(0, 0);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(238, 109);
            this.btnFiltros.TabIndex = 0;
            this.btnFiltros.Text = "FILTROS";
            this.btnFiltros.UseVisualStyleBackColor = false;
            // 
            // labelCrucero
            // 
            this.labelCrucero.AutoSize = true;
            this.labelCrucero.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCrucero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.labelCrucero.Location = new System.Drawing.Point(251, 113);
            this.labelCrucero.Margin = new System.Windows.Forms.Padding(10, 5, 3, 0);
            this.labelCrucero.Name = "labelCrucero";
            this.labelCrucero.Size = new System.Drawing.Size(166, 42);
            this.labelCrucero.TabIndex = 1;
            this.labelCrucero.Text = "Crucero:";
            // 
            // labelNombreCrucero
            // 
            this.labelNombreCrucero.AutoSize = true;
            this.labelNombreCrucero.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombreCrucero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreCrucero.Location = new System.Drawing.Point(420, 113);
            this.labelNombreCrucero.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.labelNombreCrucero.Name = "labelNombreCrucero";
            this.labelNombreCrucero.Size = new System.Drawing.Size(167, 42);
            this.labelNombreCrucero.TabIndex = 2;
            this.labelNombreCrucero.Text = "Crucero.";
            // 
            // labelInfoDestino
            // 
            this.labelInfoDestino.AutoSize = true;
            this.labelInfoDestino.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfoDestino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfoDestino.Location = new System.Drawing.Point(418, 66);
            this.labelInfoDestino.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.labelInfoDestino.Name = "labelInfoDestino";
            this.labelInfoDestino.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelInfoDestino.Size = new System.Drawing.Size(156, 42);
            this.labelInfoDestino.TabIndex = 3;
            this.labelInfoDestino.Text = "Destino";
            // 
            // btnPiscina
            // 
            this.btnPiscina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPiscina.FlatAppearance.BorderSize = 0;
            this.btnPiscina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiscina.Font = new System.Drawing.Font("Trueno", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPiscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnPiscina.Location = new System.Drawing.Point(251, 215);
            this.btnPiscina.Name = "btnPiscina";
            this.btnPiscina.Size = new System.Drawing.Size(220, 45);
            this.btnPiscina.TabIndex = 5;
            this.btnPiscina.Text = "PISCINA";
            this.btnPiscina.UseVisualStyleBackColor = false;
            // 
            // btnCasino
            // 
            this.btnCasino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCasino.FlatAppearance.BorderSize = 0;
            this.btnCasino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasino.Font = new System.Drawing.Font("Trueno", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCasino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCasino.Location = new System.Drawing.Point(251, 271);
            this.btnCasino.Name = "btnCasino";
            this.btnCasino.Size = new System.Drawing.Size(220, 45);
            this.btnCasino.TabIndex = 6;
            this.btnCasino.Text = "CASINO";
            this.btnCasino.UseVisualStyleBackColor = false;
            // 
            // labelDisponibilidad
            // 
            this.labelDisponibilidad.AutoSize = true;
            this.labelDisponibilidad.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDisponibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.labelDisponibilidad.Location = new System.Drawing.Point(251, 160);
            this.labelDisponibilidad.Margin = new System.Windows.Forms.Padding(0, 5, 3, 10);
            this.labelDisponibilidad.Name = "labelDisponibilidad";
            this.labelDisponibilidad.Size = new System.Drawing.Size(289, 42);
            this.labelDisponibilidad.TabIndex = 7;
            this.labelDisponibilidad.Text = "Disponibilidad:";
            // 
            // pictureMancha
            // 
            this.pictureMancha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMancha.Image = global::PARCIAL_01_PEREZCARDENAL.PATRICIO_.Properties.Resources.MANCHA_DECORACION2;
            this.pictureMancha.Location = new System.Drawing.Point(710, 277);
            this.pictureMancha.Name = "pictureMancha";
            this.pictureMancha.Size = new System.Drawing.Size(400, 351);
            this.pictureMancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMancha.TabIndex = 8;
            this.pictureMancha.TabStop = false;
            // 
            // labelCantidadDisponibilidad
            // 
            this.labelCantidadDisponibilidad.AutoSize = true;
            this.labelCantidadDisponibilidad.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidadDisponibilidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidadDisponibilidad.Location = new System.Drawing.Point(543, 158);
            this.labelCantidadDisponibilidad.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelCantidadDisponibilidad.Name = "labelCantidadDisponibilidad";
            this.labelCantidadDisponibilidad.Size = new System.Drawing.Size(191, 42);
            this.labelCantidadDisponibilidad.TabIndex = 9;
            this.labelCantidadDisponibilidad.Text = "Cantidad.";
            // 
            // btnEstado
            // 
            this.btnEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstado.FlatAppearance.BorderSize = 0;
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Trueno", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnEstado.Location = new System.Drawing.Point(851, 12);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(220, 45);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "ESTADO";
            this.btnEstado.UseVisualStyleBackColor = false;
            // 
            // labelCantidadPiscina
            // 
            this.labelCantidadPiscina.AutoSize = true;
            this.labelCantidadPiscina.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidadPiscina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidadPiscina.Location = new System.Drawing.Point(677, 218);
            this.labelCantidadPiscina.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelCantidadPiscina.Name = "labelCantidadPiscina";
            this.labelCantidadPiscina.Size = new System.Drawing.Size(52, 42);
            this.labelCantidadPiscina.TabIndex = 12;
            this.labelCantidadPiscina.Text = "0.";
            // 
            // labelCantidadCasino
            // 
            this.labelCantidadCasino.AutoSize = true;
            this.labelCantidadCasino.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidadCasino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidadCasino.Location = new System.Drawing.Point(677, 274);
            this.labelCantidadCasino.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelCantidadCasino.Name = "labelCantidadCasino";
            this.labelCantidadCasino.Size = new System.Drawing.Size(52, 42);
            this.labelCantidadCasino.TabIndex = 13;
            this.labelCantidadCasino.Text = "0.";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Trueno", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAnterior.Location = new System.Drawing.Point(790, 581);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(110, 34);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "<- ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Trueno", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSiguiente.Location = new System.Drawing.Point(961, 580);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(110, 34);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "SIGUIENTE ->";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.labelDestino.Location = new System.Drawing.Point(251, 66);
            this.labelDestino.Margin = new System.Windows.Forms.Padding(10, 5, 3, 0);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(164, 42);
            this.labelDestino.TabIndex = 16;
            this.labelDestino.Text = "Destino:";
            // 
            // labelCantidadViajes
            // 
            this.labelCantidadViajes.AutoSize = true;
            this.labelCantidadViajes.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidadViajes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidadViajes.Location = new System.Drawing.Point(467, 19);
            this.labelCantidadViajes.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelCantidadViajes.Name = "labelCantidadViajes";
            this.labelCantidadViajes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCantidadViajes.Size = new System.Drawing.Size(43, 42);
            this.labelCantidadViajes.TabIndex = 17;
            this.labelCantidadViajes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(434, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "/";
            // 
            // labelNumeroViajeActual
            // 
            this.labelNumeroViajeActual.AutoSize = true;
            this.labelNumeroViajeActual.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumeroViajeActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNumeroViajeActual.Location = new System.Drawing.Point(388, 19);
            this.labelNumeroViajeActual.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelNumeroViajeActual.Name = "labelNumeroViajeActual";
            this.labelNumeroViajeActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelNumeroViajeActual.Size = new System.Drawing.Size(43, 42);
            this.labelNumeroViajeActual.TabIndex = 19;
            this.labelNumeroViajeActual.Text = "0";
            // 
            // labelViaje
            // 
            this.labelViaje.AutoSize = true;
            this.labelViaje.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelViaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.labelViaje.Location = new System.Drawing.Point(251, 19);
            this.labelViaje.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelViaje.Name = "labelViaje";
            this.labelViaje.Size = new System.Drawing.Size(116, 42);
            this.labelViaje.TabIndex = 20;
            this.labelViaje.Text = "Viaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(484, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 42);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trueno", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(484, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad:";
            // 
            // btnVenderPasaje
            // 
            this.btnVenderPasaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVenderPasaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnVenderPasaje.FlatAppearance.BorderSize = 0;
            this.btnVenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderPasaje.Font = new System.Drawing.Font("Trueno", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderPasaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnVenderPasaje.Location = new System.Drawing.Point(251, 568);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(220, 45);
            this.btnVenderPasaje.TabIndex = 23;
            this.btnVenderPasaje.Text = "VENDER PREMIUM";
            this.btnVenderPasaje.UseVisualStyleBackColor = false;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // btnVenderTurista
            // 
            this.btnVenderTurista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVenderTurista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.btnVenderTurista.FlatAppearance.BorderSize = 0;
            this.btnVenderTurista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderTurista.Font = new System.Drawing.Font("Trueno", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderTurista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnVenderTurista.Location = new System.Drawing.Point(251, 510);
            this.btnVenderTurista.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnVenderTurista.Name = "btnVenderTurista";
            this.btnVenderTurista.Size = new System.Drawing.Size(220, 45);
            this.btnVenderTurista.TabIndex = 24;
            this.btnVenderTurista.Text = "VENDER TURISTA";
            this.btnVenderTurista.UseVisualStyleBackColor = false;
            this.btnVenderTurista.Click += new System.EventHandler(this.btnVenderTurista_Click);
            // 
            // FormVenderViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1083, 628);
            this.Controls.Add(this.btnVenderTurista);
            this.Controls.Add(this.btnVenderPasaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelViaje);
            this.Controls.Add(this.labelNumeroViajeActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCantidadViajes);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.labelCantidadCasino);
            this.Controls.Add(this.labelCantidadPiscina);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.labelCantidadDisponibilidad);
            this.Controls.Add(this.pictureMancha);
            this.Controls.Add(this.labelDisponibilidad);
            this.Controls.Add(this.btnCasino);
            this.Controls.Add(this.btnPiscina);
            this.Controls.Add(this.labelInfoDestino);
            this.Controls.Add(this.labelNombreCrucero);
            this.Controls.Add(this.labelCrucero);
            this.Controls.Add(this.panelBeSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenderViaje";
            this.Text = "FormVenderViaje";
            this.Load += new System.EventHandler(this.FormVenderViaje_Load);
            this.panelBeSide.ResumeLayout(false);
            this.panelBeSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMancha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBeSide;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Label labelCrucero;
        private System.Windows.Forms.Label labelNombreCrucero;
        private System.Windows.Forms.Label labelInfoDestino;
        private System.Windows.Forms.Button btnPiscina;
        private System.Windows.Forms.Button btnCasino;
        private System.Windows.Forms.Label labelDisponibilidad;
        private System.Windows.Forms.PictureBox pictureMancha;
        private System.Windows.Forms.Label labelCantidadDisponibilidad;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label labelCantidadPiscina;
        private System.Windows.Forms.Label labelCantidadCasino;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelCantidadViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumeroViajeActual;
        private System.Windows.Forms.Label labelViaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnCasino;
        private System.Windows.Forms.RadioButton radioBtnPiscina;
        private System.Windows.Forms.RadioButton radioBtnSinFiltro;
        private System.Windows.Forms.Button btnVenderPasaje;
        private System.Windows.Forms.Button btnVenderTurista;
    }
}