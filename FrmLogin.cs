namespace FazendaUrbana
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userTxt.Text == "ADMIN" && passwordTxt.Text == "ADMIN")
            {
                this.Hide();
                var frmMenu = new FrmMenu();
                frmMenu.Show(this);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTxt.Text = string.Empty;
                passwordTxt.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
