namespace CollabSecure.UI
{
    partial class FrmNuevaTarea
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
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // label1
            this.label1.Text = "Contenido de la tarea:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;

            // txtContenido
            this.txtContenido.Location = new System.Drawing.Point(20, 50);
            this.txtContenido.Size = new System.Drawing.Size(360, 120);
            this.txtContenido.Multiline = true;

            // btnGuardar
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(20, 180);
            this.btnGuardar.Size = new System.Drawing.Size(360, 35);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FrmNuevaTarea
            this.ClientSize = new System.Drawing.Size(400, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmNuevaTarea";
            this.Text = "Nueva Tarea";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnGuardar;

        #endregion
    }
}
