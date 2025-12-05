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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtPolitica = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.btnCerrar);
            this.panelContainer.Controls.Add(this.txtPolitica);
            this.panelContainer.Controls.Add(this.labelTitulo);
            this.panelContainer.Location = new System.Drawing.Point(25, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(400, 350);
            this.panelContainer.TabIndex = 0;

            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(120, 290);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // 
            // txtPolitica
            // 
            this.txtPolitica.BackColor = System.Drawing.Color.White;
            this.txtPolitica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPolitica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPolitica.Location = new System.Drawing.Point(20, 70);
            this.txtPolitica.Multiline = true;
            this.txtPolitica.Name = "txtPolitica";
            this.txtPolitica.ReadOnly = true;
            this.txtPolitica.Size = new System.Drawing.Size(355, 200);
            this.txtPolitica.TabIndex = 1;
            this.txtPolitica.TextChanged += new System.EventHandler(this.txtPolitica_TextChanged);

            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(20, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(355, 30);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Política de Privacidad";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // FrmPrivacidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPrivacidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Política de Privacidad";
            this.Load += new System.EventHandler(this.FrmPrivacidad_Load);

            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtPolitica;
        private System.Windows.Forms.Label labelTitulo;
    }
}
