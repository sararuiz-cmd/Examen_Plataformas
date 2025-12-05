namespace CollabSecure.UI
{
    partial class FrmPrivacidad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtPolitica = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPolitica
            // 
            this.txtPolitica.Location = new System.Drawing.Point(15, 15);
            this.txtPolitica.Multiline = true;
            this.txtPolitica.Name = "txtPolitica";
            this.txtPolitica.ReadOnly = true;
            this.txtPolitica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolitica.Size = new System.Drawing.Size(360, 200);
            this.txtPolitica.TabIndex = 0;
            this.txtPolitica.TextChanged += new System.EventHandler(this.txtPolitica_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(15, 225);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(360, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmPrivacidad
            // 
            this.ClientSize = new System.Drawing.Size(390, 270);
            this.Controls.Add(this.txtPolitica);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmPrivacidad";
            this.Text = "Política de Privacidad";
            this.Load += new System.EventHandler(this.FrmPrivacidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtPolitica;
        private System.Windows.Forms.Button btnCerrar;

        #endregion
    }
}