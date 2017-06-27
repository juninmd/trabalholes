using System;
using System.Windows.Forms;
using LES_17_I_N.Dao;

namespace LES_17_I_N
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkmostrasenha_CheckedChanged(object sender, EventArgs e)
        {
            txtususenha.PasswordChar = chkmostrasenha.Checked ? Char.MinValue : '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusulogin.Text) ||
                String.IsNullOrEmpty(txtususenha.Text))
            {
                MessageBox.Show("Preencha ambos os campos!!");
                return;
            }

            var user = new UsuarioDao().GetById(txtusulogin.Text, txtususenha.Text);
            if (user.Read())
            {
                Hide();
                new frmprincipal().ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique usuário/senha!!");
            }
        }
    }
}
