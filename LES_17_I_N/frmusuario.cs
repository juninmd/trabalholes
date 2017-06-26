using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }
        public PaisDao PaisDao = new PaisDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtusucodi.Clear(); // Limpa o textbox
            txtusucodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private PaisModel Entidade()
        {
            if (String.IsNullOrEmpty(txtusucodi.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new PaisModel
            {
                PAICODI = int.Parse(txtusucodi.Text),
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
            txtusucodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            PaisDao.Update(entidade);
            limpar();
            txtusucodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusucodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            PaisDao.Delete(int.Parse(txtusucodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = PaisDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvpais.DataSource = dt;
        }

        private void frmusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtusucodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusucodi.Text))
                return;

            var dr = PaisDao.GetById(int.Parse(txtusucodi.Text));
            if (dr.Read())
            {
                txtusucodi.Text = dr["PAICODI"].ToString();
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
            txtusucodi.Text = dgvpais.Rows[e.RowIndex].Cells["PAICODI"].Value.ToString();
            txtusucodi_Leave(null, null);
            tbcpais.SelectedIndex = 1;
            edicao = true;
        }
    }
}
