using System;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmtipohorario : Form
    {
        public frmtipohorario()
        {
            InitializeComponent();
        }
        public TipohorarioDao TipohorarioDao = new TipohorarioDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txttipcodi.Clear(); // Limpa o textbox
            txttipnome.Clear(); // Limpa o textbox
            txttipcodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private TipohorarioModel Entidade()
        {
            if (String.IsNullOrEmpty(txttipcodi.Text) || String.IsNullOrEmpty(txttipnome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new TipohorarioModel
            {
                THCODI = int.Parse(txttipcodi.Text),
                THNOME = txttipnome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                TipohorarioDao.Update(entidade);
            else
            {
                TipohorarioDao.Insert(entidade);
            }

            limpar();
            txttipcodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            TipohorarioDao.Update(entidade);
            limpar();
            txttipcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txttipcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            TipohorarioDao.Delete(int.Parse(txttipcodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = TipohorarioDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvtip.DataSource = dt;
        }

        private void frmtipohorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmtipohorario_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txttipcodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txttipcodi.Text))
                return;

            var dr = TipohorarioDao.GetById(int.Parse(txttipcodi.Text));
            if (dr.Read())
            {
                txttipcodi.Text = dr["THCODI"].ToString();
                txttipnome.Text = dr["THNOME"].ToString();
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
                    txttipnome.Text = "";
                    txttipnome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbctip.SelectedIndex = 0;
        }

        private void dgvtip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txttipcodi.Text = dgvtip.Rows[e.RowIndex].Cells["THCODI"].Value.ToString();
            txttipcodi_Leave(null, null);
            tbctip.SelectedIndex = 1;
            txttipnome.Focus();
            edicao = true;
        }
    }
}
