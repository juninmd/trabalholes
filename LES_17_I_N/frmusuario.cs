using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }
        public UsuarioDao UsuarioDao = new UsuarioDao();
        public FuncionarioDao FuncionarioDao = new FuncionarioDao();

        public List<string> Funcionarios { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtusunome.Clear(); // Limpa o textbox
            txtusunome.Focus(); // Vai para o textbox código
            cblfuncionario.SelectedItem = null;
            chkcontabloqueada.Checked = false;
            dtpusuexpira.Text = "";
            cblnivelacesso.SelectedItem = null;
            txtusuchances.Text = "10";
            txtususenha.Text = "";
            edicao = false;
            DgvDados();
        }

        private UsuarioModel Entidade()
        {
            if (String.IsNullOrEmpty(txtusunome.Text) ||
                cblfuncionario.SelectedItem == null ||
                cblnivelacesso.SelectedItem == null ||
                String.IsNullOrEmpty(dtpusuexpira.Text) ||
                String.IsNullOrEmpty(txtusuchances.Text) ||
                String.IsNullOrEmpty(txtususenha.Text))
            {
                MessageBox.Show("Preencha todos os dados!");
                return null;
            }


            //O campo ususenha tem que ter obrigatoriamente letras e números, sendo no mínimo
            //seis dígitos e no máximo 10
            if (txtususenha.Text.Length < 6 || txtususenha.Text.Length > 10)
            {
                MessageBox.Show("A senha deve ter no mínimo entre 6 - 10 caracteres");
                return null;
            }

            //O campo ususenha tem que ter obrigatoriamente letras e números
            if (!(txtususenha.Text.Any(char.IsDigit) &&
                txtususenha.Text.Any(char.IsLetter) &&
                  hasSpecialChar(txtususenha.Text) &&
                txtususenha.Text.Any(char.IsUpper) &&
                txtususenha.Text.Any(char.IsLower)))
            {
                MessageBox.Show("A senha deve ter obrigatoriamente caracteres especiais, números, letras minúsculas e maiúsculas.");
                return null;
            }

            return new UsuarioModel
            {
                USUNOME = txtusunome.Text,
                FUNCODI = int.Parse(cblfuncionario.SelectedItem.ToString().Split('-')[0]),
                USUBLOQ = chkcontabloqueada.Checked ? 'S' : 'N',
                USUDATA = dtpusuexpira.Value,
                USUNIVEL = int.Parse(cblnivelacesso.SelectedItem.ToString()),
                USUQTDE = int.Parse(txtusuchances.Text),
                USUSENHA = txtususenha.Text
            };
        }

        private void chkmostrasenha_CheckedChanged(object sender, EventArgs e)
        {
            txtususenha.PasswordChar = chkmostrasenha.Checked ? Char.MinValue : '*';
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                UsuarioDao.Update(entidade);
            else
            {
                UsuarioDao.Insert(entidade);
            }

            limpar();
            txtusunome.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusunome.Text))
            {
                MessageBox.Show("Preencha o username!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            UsuarioDao.Delete(txtusunome.Text);
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = UsuarioDao.GetAll();
            dgvusuario.DataSource = dt;

            cblfuncionario.Items.Clear();
            cblfuncionario.Items.AddRange(Funcionarios.ToArray());
        }

        private void frmusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {
            Funcionarios = GetFuncionarios();
            DgvDados();
        }

        private List<string> GetFuncionarios()
        {
            var lista = new List<string>();
            var itens = FuncionarioDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["FUNCODI"]} - {row["FUNNOME"]}");
            }
            return lista;
        }

        private void txtusucodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusunome.Text))
                return;

            var dr = UsuarioDao.GetById(txtusunome.Text);
            if (dr.Read())
            {
                txtusunome.Text = dr["USUNOME"].ToString();
                cblfuncionario.SelectedItem = Funcionarios.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["FUNCODI"].ToString());
                chkcontabloqueada.Checked = dr["USUBLOQ"].ToString() == "S";
                dtpusuexpira.Text = dr["USUDATA"].ToString();
                cblnivelacesso.SelectedItem = dr["USUNIVEL"].ToString();
                txtusuchances.Text = dr["USUQTDE"].ToString();
                txtususenha.Text = dr["USUSENHA"].ToString();
                edicao = true;
            }
            else
            {
                edicao = false;
                if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                {
                    limpar();
                }
                else
                {
                    cblfuncionario.SelectedItem = null;
                    chkcontabloqueada.Checked = false;
                    dtpusuexpira.Text = "";
                    cblnivelacesso.SelectedItem = null;
                    txtusuchances.Text = "10";
                    txtususenha.Text = "";
                    edicao = false;
                    DgvDados();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcusuario.SelectedIndex = 0;
        }

        private void dgvpais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtusunome.Text = dgvusuario.Rows[e.RowIndex].Cells["USUNOME"].Value.ToString();
            txtusucodi_Leave(null, null);
            tbcusuario.SelectedIndex = 1;
            edicao = true;
        }
    }
}
