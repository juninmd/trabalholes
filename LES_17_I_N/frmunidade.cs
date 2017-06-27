using System;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmunidade : Form
    {
        public frmunidade()
        {
            InitializeComponent();
        }
        public UnidadeDao UnidadeDao = new UnidadeDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtunidadecodi.Clear(); // Limpa o textbox
            txtunidadenome.Clear(); // Limpa o textbox
            txtunidadecodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private UnidadeModel Entidade()
        {
            if (String.IsNullOrEmpty(txtunidadecodi.Text) || String.IsNullOrEmpty(txtunidadenome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new UnidadeModel
            {
                UNICODI = int.Parse(txtunidadecodi.Text),
                UNINOME = txtunidadenome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                UnidadeDao.Update(entidade);
            else
            {
                UnidadeDao.Insert(entidade);
            }

            limpar();
            txtunidadecodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            UnidadeDao.Update(entidade);
            limpar();
            txtunidadecodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtunidadecodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            UnidadeDao.Delete(int.Parse(txtunidadecodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = UnidadeDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvunidade.DataSource = dt;
        }

        private void frmunidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmunidade_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtunidadecodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtunidadecodi.Text))
                return;

            var dr = UnidadeDao.GetById(int.Parse(txtunidadecodi.Text));
            if (dr.Read())
            {
                txtunidadecodi.Text = dr["UNICODI"].ToString();
                txtunidadenome.Text = dr["UNINOME"].ToString();
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
                    txtunidadenome.Text = "";
                    txtunidadenome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcunidade.SelectedIndex = 0;
        }

        private void dgvunidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtunidadecodi.Text = dgvunidade.Rows[e.RowIndex].Cells["UNICODI"].Value.ToString();
            txtunidadecodi_Leave(null, null);
            tbcunidade.SelectedIndex = 1;
            txtunidadenome.Focus();
            edicao = true;
        }
    }
}
