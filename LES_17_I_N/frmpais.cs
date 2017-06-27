using System;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmpais : Form
    {
        public frmpais()
        {
            InitializeComponent();
        }
        public PaisDao PaisDao = new PaisDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtpaicodi.Clear(); // Limpa o textbox
            txtpainome.Clear(); // Limpa o textbox
            txtpaicodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private PaisModel Entidade()
        {
            if (String.IsNullOrEmpty(txtpaicodi.Text) || String.IsNullOrEmpty(txtpainome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new PaisModel
            {
                PAICODI = int.Parse(txtpaicodi.Text),
                PAINOME = txtpainome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                PaisDao.Update(entidade);
            else
            {
                PaisDao.Insert(entidade);
            }

            limpar();
            txtpaicodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            PaisDao.Update(entidade);
            limpar();
            txtpaicodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpaicodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            PaisDao.Delete(int.Parse(txtpaicodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = PaisDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvpais.DataSource = dt;
        }

        private void frmpais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmpais_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpaicodi.Text))
                return;

            var dr = PaisDao.GetById(int.Parse(txtpaicodi.Text));
            if (dr.Read())
            {
                txtpaicodi.Text = dr["PAICODI"].ToString();
                txtpainome.Text = dr["PAINOME"].ToString();
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
                    txtpainome.Text = "";
                    txtpainome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcpais.SelectedIndex = 0;
        }

        private void dgvpais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtpaicodi.Text = dgvpais.Rows[e.RowIndex].Cells["PAICODI"].Value.ToString();
            txtpaicodi_Leave(null, null);
            tbcpais.SelectedIndex = 1;
            txtpainome.Focus();
            edicao = true;
        }
    }
}
