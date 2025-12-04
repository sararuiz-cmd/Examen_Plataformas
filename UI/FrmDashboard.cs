using CollabSecure.Data;
using CollabSecure.Domain;
using System;
using System.Windows.Forms;

namespace CollabSecure.UI
{
    public partial class FrmDashboard : Form
    {
        private readonly string usuario;
        private readonly TareaRepository repo = new TareaRepository();

        public FrmDashboard(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void CargarTareas()
        {
            var lista = repo.Cargar();
            dgvTareas.DataSource = lista;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            var form = new FrmNuevaTarea(usuario, repo);
            form.FormClosed += (s, a) => CargarTareas();
            form.ShowDialog();
        }
    }
}
