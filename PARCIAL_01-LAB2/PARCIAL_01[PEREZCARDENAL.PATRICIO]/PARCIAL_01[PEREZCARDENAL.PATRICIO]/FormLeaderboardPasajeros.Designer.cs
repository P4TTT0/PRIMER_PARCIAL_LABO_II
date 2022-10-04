
namespace PARCIAL_01_PEREZCARDENAL.PATRICIO_
{
    partial class FormLeaderboardPasajeros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridLeaderboardPasajero = new System.Windows.Forms.DataGridView();
            this.labelBienvenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaderboardPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLeaderboardPasajero
            // 
            this.dataGridLeaderboardPasajero.AllowUserToAddRows = false;
            this.dataGridLeaderboardPasajero.AllowUserToDeleteRows = false;
            this.dataGridLeaderboardPasajero.AllowUserToResizeColumns = false;
            this.dataGridLeaderboardPasajero.AllowUserToResizeRows = false;
            this.dataGridLeaderboardPasajero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLeaderboardPasajero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLeaderboardPasajero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridLeaderboardPasajero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLeaderboardPasajero.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridLeaderboardPasajero.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trueno", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLeaderboardPasajero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLeaderboardPasajero.ColumnHeadersHeight = 30;
            this.dataGridLeaderboardPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridLeaderboardPasajero.EnableHeadersVisualStyles = false;
            this.dataGridLeaderboardPasajero.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridLeaderboardPasajero.Location = new System.Drawing.Point(12, 91);
            this.dataGridLeaderboardPasajero.Name = "dataGridLeaderboardPasajero";
            this.dataGridLeaderboardPasajero.ReadOnly = true;
            this.dataGridLeaderboardPasajero.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridLeaderboardPasajero.RowHeadersVisible = false;
            this.dataGridLeaderboardPasajero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trueno", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridLeaderboardPasajero.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLeaderboardPasajero.RowTemplate.Height = 25;
            this.dataGridLeaderboardPasajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLeaderboardPasajero.Size = new System.Drawing.Size(1061, 538);
            this.dataGridLeaderboardPasajero.TabIndex = 2;
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Trueno", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(175)))));
            this.labelBienvenido.Location = new System.Drawing.Point(12, 11);
            this.labelBienvenido.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(671, 77);
            this.labelBienvenido.TabIndex = 3;
            this.labelBienvenido.Text = "Viajes de pasajeros:";
            // 
            // FormLeaderboardPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1085, 641);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.dataGridLeaderboardPasajero);
            this.Name = "FormLeaderboardPasajeros";
            this.Text = "FormLeaderboardPasajeros";
            this.Load += new System.EventHandler(this.FormLeaderboardPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaderboardPasajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLeaderboardPasajero;
        private System.Windows.Forms.Label labelBienvenido;
    }
}