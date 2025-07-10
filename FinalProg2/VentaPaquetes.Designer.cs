namespace FinalProg2
{
    partial class VentaPaquetes
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
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.tbPrecioIndividual = new System.Windows.Forms.TextBox();
            this.tbPatenteIda = new System.Windows.Forms.TextBox();
            this.tbPatenteVuelta = new System.Windows.Forms.TextBox();
            this.cbxTransporteVuelta = new System.Windows.Forms.ComboBox();
            this.cbxTransporteIda = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(12, 12);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(179, 21);
            this.cbxDestino.TabIndex = 0;
            this.cbxDestino.Text = "Destino";
            this.cbxDestino.SelectedIndexChanged += new System.EventHandler(this.cbxDestino_SelectedIndexChanged);
            // 
            // tbPrecioIndividual
            // 
            this.tbPrecioIndividual.Location = new System.Drawing.Point(12, 39);
            this.tbPrecioIndividual.Name = "tbPrecioIndividual";
            this.tbPrecioIndividual.ReadOnly = true;
            this.tbPrecioIndividual.Size = new System.Drawing.Size(179, 20);
            this.tbPrecioIndividual.TabIndex = 1;
            this.tbPrecioIndividual.Text = "PrecioIndividual";
            // 
            // tbPatenteIda
            // 
            this.tbPatenteIda.Location = new System.Drawing.Point(12, 92);
            this.tbPatenteIda.Name = "tbPatenteIda";
            this.tbPatenteIda.Size = new System.Drawing.Size(179, 20);
            this.tbPatenteIda.TabIndex = 2;
            this.tbPatenteIda.Text = "Patente/Vuelo ida";
            // 
            // tbPatenteVuelta
            // 
            this.tbPatenteVuelta.Location = new System.Drawing.Point(12, 145);
            this.tbPatenteVuelta.Name = "tbPatenteVuelta";
            this.tbPatenteVuelta.Size = new System.Drawing.Size(179, 20);
            this.tbPatenteVuelta.TabIndex = 3;
            this.tbPatenteVuelta.Text = "Patente/Vuelvo Vuelta";
            // 
            // cbxTransporteVuelta
            // 
            this.cbxTransporteVuelta.FormattingEnabled = true;
            this.cbxTransporteVuelta.Items.AddRange(new object[] {
            "Bus",
            "Avion"});
            this.cbxTransporteVuelta.Location = new System.Drawing.Point(12, 118);
            this.cbxTransporteVuelta.Name = "cbxTransporteVuelta";
            this.cbxTransporteVuelta.Size = new System.Drawing.Size(179, 21);
            this.cbxTransporteVuelta.TabIndex = 4;
            this.cbxTransporteVuelta.Text = "Transporte Vuelta";
            // 
            // cbxTransporteIda
            // 
            this.cbxTransporteIda.FormattingEnabled = true;
            this.cbxTransporteIda.Items.AddRange(new object[] {
            "Bus",
            "Avion"});
            this.cbxTransporteIda.Location = new System.Drawing.Point(12, 65);
            this.cbxTransporteIda.Name = "cbxTransporteIda";
            this.cbxTransporteIda.Size = new System.Drawing.Size(179, 21);
            this.cbxTransporteIda.TabIndex = 5;
            this.cbxTransporteIda.Text = "Transporte Ida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTarjeta);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbCuit);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pasajero";
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Location = new System.Drawing.Point(6, 100);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Size = new System.Drawing.Size(159, 20);
            this.tbTarjeta.TabIndex = 10;
            this.tbTarjeta.Text = "Tarjeta";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(6, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(159, 20);
            this.tbNombre.TabIndex = 8;
            this.tbNombre.Text = "Nombre";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(6, 74);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(159, 20);
            this.tbTelefono.TabIndex = 9;
            this.tbTelefono.Text = "Telefono";
            // 
            // tbCuit
            // 
            this.tbCuit.Location = new System.Drawing.Point(6, 22);
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(159, 20);
            this.tbCuit.TabIndex = 7;
            this.tbCuit.Text = "Cuit";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(12, 322);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 49);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VentaPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxTransporteIda);
            this.Controls.Add(this.cbxTransporteVuelta);
            this.Controls.Add(this.tbPatenteVuelta);
            this.Controls.Add(this.tbPatenteIda);
            this.Controls.Add(this.tbPrecioIndividual);
            this.Controls.Add(this.cbxDestino);
            this.Name = "VentaPaquetes";
            this.Text = "VentaPaquetes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbxDestino;
        public System.Windows.Forms.TextBox tbPrecioIndividual;
        public System.Windows.Forms.TextBox tbPatenteIda;
        public System.Windows.Forms.TextBox tbPatenteVuelta;
        public System.Windows.Forms.ComboBox cbxTransporteVuelta;
        public System.Windows.Forms.ComboBox cbxTransporteIda;
        public System.Windows.Forms.TextBox tbTarjeta;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbTelefono;
        public System.Windows.Forms.TextBox tbCuit;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
    }
}