using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmproduto : Form
    {
        public frmproduto()
        {
            InitializeComponent();
        }
        public ProdutoDao ProdutoDao = new ProdutoDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtprocodi.Clear(); // Limpa o textbox
            txtpronome.Clear(); // Limpa o textbox
            txtprocodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private ProdutoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtprocodi.Text) || String.IsNullOrEmpty(txtpronome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new ProdutoModel
            {
                PROCODI = int.Parse(txtprocodi.Text),
                PRONOME = txtpronome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                ProdutoDao.Update(entidade);
            else
            {
                ProdutoDao.Insert(entidade);
            }

            limpar();
            txtprocodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            ProdutoDao.Update(entidade);
            limpar();
            txtprocodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprocodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            ProdutoDao.Delete(int.Parse(txtprocodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = ProdutoDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvpro.DataSource = dt;
        }

        private void frmproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtprocodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprocodi.Text))
                return;

            var dr = ProdutoDao.GetById(int.Parse(txtprocodi.Text));
            if (dr.Read())
            {
                txtprocodi.Text = dr["PROCODI"].ToString();
                txtpronome.Text = dr["PRONOME"].ToString();
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
                    txtpronome.Text = "";
                    txtpronome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcpro.SelectedIndex = 0;
        }

        private void dgvprod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtprocodi.Text = dgvpro.Rows[e.RowIndex].Cells["PROCODI"].Value.ToString();
            txtprocodi_Leave(null, null);
            tbcpro.SelectedIndex = 1;
            txtpronome.Focus();
            edicao = true;
        }
    }
}
