using System;
using System.Windows.Forms;
using CollabSecure.Data;
using CollabSecure.Domain;
using CollabSecure.Security;



namespace CollabSecure.UI
{
    public partial class FrmNuevaTarea : Form
    {
        private readonly string autor;
        private readonly TareaRepository repo;

        public FrmNuevaTarea(string autor, TareaRepository repo)
        {
            InitializeComponent();
            this.autor = autor;
            this.repo = repo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string texto = txtContenido.Text.Trim();

            // Validaciones básicas
            if (!ValidationService.ValidarTexto(texto))
            {
                MessageBox.Show("El texto no puede ser vacío ni mayor a 200 caracteres.");
                return;
            }

            // Filtro de lenguaje ofensivo
            if (ContentFilter.ContieneContenidoOfensivo(texto))
            {
                MessageBox.Show("El mensaje contiene lenguaje ofensivo.");
                return;
            }

            // Crear tarea
            Tarea tarea = new Tarea
            {
                Autor = autor,
                Contenido = texto,
                Fecha = DateTime.Now
            };

            // Guardar en TXT
            repo.Guardar(tarea);

            MessageBox.Show("Tarea guardada correctamente.");
            this.Close();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNuevaTarea_Load(object sender, EventArgs e)
        {

        }
    }
}
