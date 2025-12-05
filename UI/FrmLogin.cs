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
        private void btnPrivacidad_Click(object sender, EventArgs e)
        {
            FrmPrivacidad priv = new FrmPrivacidad();
            priv.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (auth.Login(txtUser.Text, txtPass.Text))
            {
                FrmDashboard dash = new FrmDashboard(txtUser.Text);
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
    }
}