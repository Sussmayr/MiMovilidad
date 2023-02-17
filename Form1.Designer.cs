namespace ProyectoVisualEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.DGVViajes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPRegistrarViaje = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(748, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarjeta";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarjeta.Location = new System.Drawing.Point(102, 379);
            this.lblTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(151, 23);
            this.lblTarjeta.TabIndex = 9;
            this.lblTarjeta.Text = "044517524C6580";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(874, 55);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 23);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // DGVViajes
            // 
            this.DGVViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViajes.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DGVViajes.Location = new System.Drawing.Point(15, 417);
            this.DGVViajes.Name = "DGVViajes";
            this.DGVViajes.RowHeadersWidth = 51;
            this.DGVViajes.RowTemplate.Height = 24;
            this.DGVViajes.Size = new System.Drawing.Size(1094, 261);
            this.DGVViajes.TabIndex = 14;
            this.DGVViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVViajes_CellClick);
            this.DGVViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVViajes_CellContentClick);
            this.DGVViajes.DoubleClick += new System.EventHandler(this.DGVViajes_DoubleClick);
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarViaje.Location = new System.Drawing.Point(878, 182);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(231, 67);
            this.btnRegistrarViaje.TabIndex = 15;
            this.btnRegistrarViaje.Text = "Registrar Viaje";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExportar.Location = new System.Drawing.Point(1011, 381);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(98, 30);
            this.BtnExportar.TabIndex = 16;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(514, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Historial de Viajes";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoVisualEventos.Properties.Resources.MI_MOVILIDAD;
            this.panel1.Location = new System.Drawing.Point(15, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 353);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(724, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registrar Viaje";
            // 
            // DTPRegistrarViaje
            // 
            this.DTPRegistrarViaje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPRegistrarViaje.Location = new System.Drawing.Point(878, 121);
            this.DTPRegistrarViaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPRegistrarViaje.Name = "DTPRegistrarViaje";
            this.DTPRegistrarViaje.Size = new System.Drawing.Size(231, 31);
            this.DTPRegistrarViaje.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1129, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.DGVViajes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPRegistrarViaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Mi Movilidad";
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView DGVViajes;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPRegistrarViaje;
    }
}

