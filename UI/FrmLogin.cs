using CollabSecure.Security;
using System;
using System.Windows.Forms;

namespace CollabSecure.UI
{
    public partial class FrmLogin : Form
    {
        private AuthService auth = new AuthService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnPrivacidad_Click(object sender, EventArgs e)
        {
            FrmPrivacidad priv = new FrmPrivacidad();
            priv.ShowDialog();
        }

        // =====================================
        //     INICIAR SESIÓN
        // =====================================
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            if (auth.Login(user, pass))
            {
                FrmDashboard dash = new FrmDashboard(user);
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        // =====================================
        //     REGISTRAR NUEVO USUARIO
        // =====================================
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            bool registrado = auth.RegistrarUsuario(user, pass);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado correctamente.");
            }
            else
            {
                MessageBox.Show("El usuario ya existe o los datos son inválidos.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
