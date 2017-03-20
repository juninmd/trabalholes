using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmcbo : Form
    {
        public frmcbo()
        {
            InitializeComponent();
        }
        public CboDao CboDao = new CboDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtcbocodi.Clear(); // Limpa o textbox
            txtcbonome.Clear(); // Limpa o textbox
            txtcbocodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private CboModel Entidade()
        {
            if (String.IsNullOrEmpty(txtcbocodi.Text) || String.IsNullOrEmpty(txtcbonome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new CboModel
            {
                CBOCODI = int.Parse(txtcbocodi.Text),
                CBONOME = txtcbonome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                CboDao.Update(entidade);
            else
            {
                CboDao.Insert(entidade);
            }

            limpar();
            txtcbocodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            CboDao.Update(entidade);
            limpar();
            txtcbocodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcbocodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            CboDao.Delete(int.Parse(txtcbocodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = CboDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvcbo.DataSource = dt;
        }

        private void frmcbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmcbo_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtcbocodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcbocodi.Text))
                return;

            var dr = CboDao.GetById(int.Parse(txtcbocodi.Text));
            if (dr.Read())
            {
                txtcbocodi.Text = dr["CBOCODI"].ToString();
                txtcbonome.Text = dr["CBONOME"].ToString();
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
                    txtcbonome.Text = "";
                    txtcbonome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbccbo.SelectedIndex = 0;
        }

        private void dgvcbo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtcbocodi.Text = dgvcbo.Rows[e.RowIndex].Cells["CBOCODI"].Value.ToString();
            txtcbocodi_Leave(null, null);
            tbccbo.SelectedIndex = 1;
            txtcbonome.Focus();
            edicao = true;
        }
    }
}
