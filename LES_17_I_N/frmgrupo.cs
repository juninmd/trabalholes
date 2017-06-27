using System;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmgrupo : Form
    {
        public frmgrupo()
        {
            InitializeComponent();
        }
        public GrupoDao GrupoDao = new GrupoDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtgrupocodi.Clear(); // Limpa o textbox
            txtgruponome.Clear(); // Limpa o textbox
            txtgrupocodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private GrupoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtgrupocodi.Text) || String.IsNullOrEmpty(txtgruponome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new GrupoModel
            {
                GRUCODI = int.Parse(txtgrupocodi.Text),
                GRUNOME = txtgruponome.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                GrupoDao.Update(entidade);
            else
            {
                GrupoDao.Insert(entidade);
            }

            limpar();
            txtgrupocodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            GrupoDao.Update(entidade);
            limpar();
            txtgrupocodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtgrupocodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            GrupoDao.Delete(int.Parse(txtgrupocodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = GrupoDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvgrupo.DataSource = dt;
        }

        private void frmgrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmgrupo_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtgrupocodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtgrupocodi.Text))
                return;

            var dr = GrupoDao.GetById(int.Parse(txtgrupocodi.Text));
            if (dr.Read())
            {
                txtgrupocodi.Text = dr["GRUCODI"].ToString();
                txtgruponome.Text = dr["GRUNOME"].ToString();
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
                    txtgruponome.Text = "";
                    txtgruponome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcgrupo.SelectedIndex = 0;
        }

        private void dgvgrupo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtgrupocodi.Text = dgvgrupo.Rows[e.RowIndex].Cells["GRUCODI"].Value.ToString();
            txtgrupocodi_Leave(null, null);
            tbcgrupo.SelectedIndex = 1;
            txtgruponome.Focus();
            edicao = true;
        }
    }
}
