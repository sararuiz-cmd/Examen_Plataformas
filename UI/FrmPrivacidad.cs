using System.Windows.Forms;

namespace CollabSecure.UI
{
    public partial class FrmPrivacidad : Form
    {
        public FrmPrivacidad()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void FrmPrivacidad_Load(object sender, System.EventArgs e)
        {
            txtPolitica.Text =
                "Su información se usa únicamente dentro de la aplicación.\n" +
                "No se comparte con terceros.\n" +
                "Al continuar, usted acepta este uso responsable.";
        }
    }
}
