namespace FinalProg2
{
    partial class Resumen
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
            this.lbDestinos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDestinos
            // 
            this.lbDestinos.FormattingEnabled = true;
            this.lbDestinos.Location = new System.Drawing.Point(12, 12);
            this.lbDestinos.Name = "lbDestinos";
            this.lbDestinos.Size = new System.Drawing.Size(506, 199);
            this.lbDestinos.TabIndex = 0;
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 226);
            this.Controls.Add(this.lbDestinos);
            this.Name = "Resumen";
            this.Text = "Resumen";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbDestinos;
    }
}