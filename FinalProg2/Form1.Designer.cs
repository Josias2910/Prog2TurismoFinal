namespace FinalProg2
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
            this.btnGenerarPaquete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarDestinos = new System.Windows.Forms.Button();
            this.lbDestinos = new System.Windows.Forms.ListBox();
            this.btnResumen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarPaquete
            // 
            this.btnGenerarPaquete.Location = new System.Drawing.Point(6, 19);
            this.btnGenerarPaquete.Name = "btnGenerarPaquete";
            this.btnGenerarPaquete.Size = new System.Drawing.Size(75, 46);
            this.btnGenerarPaquete.TabIndex = 0;
            this.btnGenerarPaquete.Text = "Generar Paquete";
            this.btnGenerarPaquete.UseVisualStyleBackColor = true;
            this.btnGenerarPaquete.Click += new System.EventHandler(this.btnGenerarPaquete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResumen);
            this.groupBox1.Controls.Add(this.btnCargarDestinos);
            this.groupBox1.Controls.Add(this.btnGenerarPaquete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquetes";
            // 
            // btnCargarDestinos
            // 
            this.btnCargarDestinos.Location = new System.Drawing.Point(87, 19);
            this.btnCargarDestinos.Name = "btnCargarDestinos";
            this.btnCargarDestinos.Size = new System.Drawing.Size(75, 46);
            this.btnCargarDestinos.TabIndex = 1;
            this.btnCargarDestinos.Text = "Cargar Destinos";
            this.btnCargarDestinos.UseVisualStyleBackColor = true;
            this.btnCargarDestinos.Click += new System.EventHandler(this.btnCargarDestinos_Click);
            // 
            // lbDestinos
            // 
            this.lbDestinos.FormattingEnabled = true;
            this.lbDestinos.Location = new System.Drawing.Point(44, 96);
            this.lbDestinos.Name = "lbDestinos";
            this.lbDestinos.Size = new System.Drawing.Size(183, 95);
            this.lbDestinos.TabIndex = 2;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(168, 19);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(75, 46);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 199);
            this.Controls.Add(this.lbDestinos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPaquete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargarDestinos;
        private System.Windows.Forms.ListBox lbDestinos;
        private System.Windows.Forms.Button btnResumen;
    }
}

