using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmramo : Form
    {
        public frmramo()
        {
            InitializeComponent();
        }
        public RamoDao RamoDao = new RamoDao();
        public bool edicao { get; set; }

        private void limpar()
        {
            txtramocodi.Clear(); // Limpa o textbox
            txtramonome.Clear(); // Limpa o textbox
            txtramobs.Clear(); // Limpa o textbox
            txtramocodi.Focus(); // Vai para o textbox código
            edicao = false;
            DgvDados();
        }

        private RamoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtramocodi.Text) || String.IsNullOrEmpty(txtramonome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new RamoModel
            {
                RAMCODI = int.Parse(txtramocodi.Text),
                RAMNOME = txtramonome.Text,
                RAMOBSE = txtramobs.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                RamoDao.Update(entidade);
            else
            {
                RamoDao.Insert(entidade);
            }

            limpar();
            txtramocodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            RamoDao.Update(entidade);
            limpar();
            txtramocodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtramocodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            RamoDao.Delete(int.Parse(txtramocodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = RamoDao.GetAll();
            if (dt.Rows.Count > 0)
                dgvramo.DataSource = dt;
        }

        private void frmramo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmramo_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtramocodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtramocodi.Text))
                return;

            var dr = RamoDao.GetById(int.Parse(txtramocodi.Text));
            if (dr.Read())
            {
                txtramocodi.Text = dr["RAMCODI"].ToString();
                txtramonome.Text = dr["RAMNOME"].ToString();
                txtramobs.Text = dr["RAMOBSE"].ToString();
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
                    txtramonome.Text = "";
                    txtramonome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcramo.SelectedIndex = 0;
        }

        private void dgvramo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtramocodi.Text = dgvramo.Rows[e.RowIndex].Cells["RAMCODI"].Value.ToString();
            txtramocodi_Leave(null, null);
            tbcramo.SelectedIndex = 1;
            txtramonome.Focus();
            edicao = true;
        }
    }
}
