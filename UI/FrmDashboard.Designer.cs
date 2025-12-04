namespace CollabSecure.UI
{
    partial class FrmDashboard
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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnNueva = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();

            // dgvTareas
            this.dgvTareas.Location = new System.Drawing.Point(20, 60);
            this.dgvTareas.Size = new System.Drawing.Size(500, 250);
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.AllowUserToAddRows = false;

            // btnNueva
            this.btnNueva.Text = "Nueva Tarea";
            this.btnNueva.Location = new System.Drawing.Point(20, 20);
            this.btnNueva.Size = new System.Drawing.Size(140, 30);
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);

            // labelUsuario
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.Location = new System.Drawing.Point(380, 20);
            this.labelUsuario.AutoSize = true;

            // FrmDashboard
            this.ClientSize = new System.Drawing.Size(550, 330);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.labelUsuario);
            this.Name = "FrmDashboard";
            this.Text = "CollabSecure - Panel de Tareas";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label labelUsuario;

        #endregion
    }
}
