namespace CollabSecure.UI
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnPrivacidad = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Text = "Usuario:";
            this.label1.Location = new System.Drawing.Point(25, 25);

            // label2
            this.label2.AutoSize = true;
            this.label2.Text = "Contraseña:";
            this.label2.Location = new System.Drawing.Point(25, 70);

            // txtUser
            this.txtUser.Location = new System.Drawing.Point(120, 22);
            this.txtUser.Size = new System.Drawing.Size(180, 23);

            // txtPass
            this.txtPass.Location = new System.Drawing.Point(120, 67);
            this.txtPass.Size = new System.Drawing.Size(180, 23);
            this.txtPass.PasswordChar = '*';

            // btnEntrar
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Location = new System.Drawing.Point(120, 110);
            this.btnEntrar.Size = new System.Drawing.Size(180, 30);
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

            // btnPrivacidad
            this.btnPrivacidad.Text = "Política de Privacidad";
            this.btnPrivacidad.Location = new System.Drawing.Point(120, 150);
            this.btnPrivacidad.Size = new System.Drawing.Size(180, 25);
            this.btnPrivacidad.Click += new System.EventHandler(this.btnPrivacidad_Click);

            // FrmLogin
            this.ClientSize = new System.Drawing.Size(340, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnPrivacidad);
            this.Name = "FrmLogin";
            this.Text = "CollabSecure - Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnPrivacidad;

        #endregion
    }
}