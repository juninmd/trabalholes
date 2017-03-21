using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmdepto : Form
    {
        public frmdepto()
        {
            InitializeComponent();
        }
        public DeptoDao DeptoDao = new DeptoDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtdepcodi.Clear(); // Limpa o textbox
            txtdepnome.Clear(); // Limpa o textbox
            txtdepcodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private DeptoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtdepcodi.Text) || String.IsNullOrEmpty(txtdepnome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new DeptoModel
            {
                DEPCODI = int.Parse(txtdepcodi.Text),
                DEPNOME = txtdepnome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                DeptoDao.Update(entidade);
            else
            {
                DeptoDao.Insert(entidade);
            }

            limpar();
            txtdepcodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            DeptoDao.Update(entidade);
            limpar();
            txtdepcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdepcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            DeptoDao.Delete(int.Parse(txtdepcodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = DeptoDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvdep.DataSource = dt;
        }

        private void frmdepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmdepto_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtdepcodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdepcodi.Text))
                return;

            var dr = DeptoDao.GetById(int.Parse(txtdepcodi.Text));
            if (dr.Read())
            {
                txtdepcodi.Text = dr["DEPCODI"].ToString();
                txtdepnome.Text = dr["DEPNOME"].ToString();
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
                    txtdepnome.Text = "";
                    txtdepnome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcdep.SelectedIndex = 0;
        }

        private void dgvdep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtdepcodi.Text = dgvdep.Rows[e.RowIndex].Cells["DEPCODI"].Value.ToString();
            txtdepcodi_Leave(null, null);
            tbcdep.SelectedIndex = 1;
            txtdepnome.Focus();
            edicao = true;
        }
    }
}
