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

        public int Erros { get; set; }

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
                if (user["USUBLOQ"].ToString() == "S")
                {
                    MessageBox.Show("Seu usuário está bloqueado!");
                    return;
                }

                var data = DateTime.Parse(user["USUDATA"].ToString()).AddDays(30d);
                if (data <= DateTime.Now)
                {
                    Hide();
                    new frmsenha(txtusulogin.Text, int.Parse(user["USUQTDE"].ToString())).ShowDialog();
                    return;
                }

                Hide();
                new frmprincipal().ShowDialog();
            }
            else
            {
                if (Erros >= 3)
                {
                    new UsuarioDao().Bloquear(txtusulogin.Text);
                    MessageBox.Show("Usuário bloqueado!");
                    return;
                }
                Erros += 1;
                MessageBox.Show("Verifique usuário/senha!!");
            }
        }
    }
}
