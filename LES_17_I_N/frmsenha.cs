using System;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmsenha : Form
    {
        public frmsenha(string login, int chances)
        {
            Login = login;
            Chances = chances;
            InitializeComponent();
            lblchances.Text = Chances.ToString();
        }

        public string Login { get; set; }
        public int Chances { get; set; }

        private void chkmostrasenha_CheckedChanged(object sender, EventArgs e)
        {
            txtususenha.PasswordChar = chkmostrasenha.Checked ? Char.MinValue : '*';
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtususenha.Text))
            {
                MessageBox.Show("Preencha a senha!");
                return;
            }

            var usuarioEntidade = new UsuarioModel { USUNOME = Login, USUSENHA = txtususenha.Text };
            var usuarioOriginal = new UsuarioDao().GetById(usuarioEntidade.USUNOME);
            if (usuarioOriginal.Read())
            {
                if (usuarioOriginal["USUSENHA"].ToString() == usuarioEntidade.USUSENHA)
                {
                    MessageBox.Show("A senha não pode ser a mesma!");
                    return;
                }
            }
            new UsuarioDao().AlterarSenha(usuarioEntidade);
            new frmprincipal().ShowDialog();
            Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            var usuarioEntidade = new UsuarioModel { USUNOME = Login, USUQTDE = Chances };

            if (Chances > 1)
            {
                Chances -= 1;
                new UsuarioDao().ChancesBloqueio(usuarioEntidade);
                new frmprincipal().ShowDialog();
                Hide();
            }
            new UsuarioDao().Bloquear(Login);
            Chances -= 1;
            new UsuarioDao().ChancesBloqueio(usuarioEntidade);
            MessageBox.Show("Usuário bloqueado!");
            Application.Exit();
        }
    }
}
