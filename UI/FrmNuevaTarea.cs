using CollabSecure.Data;
using CollabSecure.Domain;
using CollabSecure.Security;
using System;
using System.Windows.Forms;

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
            string texto = txtContenido.Text;

            if (!ValidationService.ValidarTexto(texto))
            {
                MessageBox.Show("Texto inválido o demasiado largo.");
                return;
            }

            if (ContentFilter.ContieneContenidoOfensivo(texto))
            {
                MessageBox.Show("El mensaje contiene lenguaje ofensivo.");
                return;
            }

            repo.Guardar(new Tarea
            {
                Autor = autor,
                Contenido = texto,
                Fecha = DateTime.Now
            });

            MessageBox.Show("Tarea registrada.");
            Close();
        }
    }
}
