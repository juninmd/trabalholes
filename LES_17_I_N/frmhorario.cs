using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmhorario : Form
    {
        public frmhorario()
        {
            InitializeComponent();
        }
        public TipohorarioDao TipohorarioDao = new TipohorarioDao();
        public HorarioDao HorarioDao = new HorarioDao();

        public List<string> Paises { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txthorcodi.Clear(); // Limpa o textbox
            txthornome.Clear(); // Limpa o textbox
            txthoricms.Clear(); // Limpa o textbox
            txthoruf.Clear(); // Limpa o textbox
            txthorcodi.Focus(); // Vai para o textbox código
            cbltip.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private HorarioModel Entidade()
        {
            if (String.IsNullOrEmpty(txthorcodi.Text) ||
                String.IsNullOrEmpty(txthornome.Text) ||
                String.IsNullOrEmpty(txthoricms.Text) ||
                String.IsNullOrEmpty(txthoruf.Text) ||
                (cbltip.SelectedItem) == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new HorarioModel
            {
                HORCODI = int.Parse(txthorcodi.Text),
                HORNOME = txthornome.Text,
                HORMANE = txthoricms.Text,
                HORMANS = txthoruf.Text,
                HORTARS = txthoruf.Text,
                HORTARE = txthoruf.Text,
                THCODI = int.Parse(cbltip.Text.Split('-')[0])
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                HorarioDao.Update(entidade);
            else
            {
                HorarioDao.Insert(entidade);
            }

            limpar();
            txthorcodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            HorarioDao.Update(entidade);
            limpar();
            txthorcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txthorcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            HorarioDao.Delete(int.Parse(txthorcodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = HorarioDao.GetAll();
            cbltip.Items.Clear();
            cbltip.Items.AddRange(Paises.ToArray());
            if (dt.Rows.Count > 0)
                dvgestado.DataSource = dt;
        }

        private void frmhoraio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmhoraio_Load(object sender, EventArgs e)
        {
            Paises = GetPaises();
            DgvDados();
        }

        private List<string> GetPaises()
        {
            var lista = new List<string>();
            var all = TipohorarioDao.GetAll();
            foreach (var item in all.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["THCODI"]} - {row["THNOME"]}");
            }
            return lista;
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txthorcodi.Text))
                return;

            var dr = HorarioDao.GetById(int.Parse(txthorcodi.Text));
            if (dr.Read())
            {
                txthorcodi.Text = dr["HORCODI"].ToString();
                txthornome.Text = dr["HORNOME"].ToString();
                txthoruf.Text = dr["ESTUF"].ToString();
                txthoricms.Text = dr["ESTICMS"].ToString();
                cbltip.SelectedItem = Paises.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["THCODI"].ToString());
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
                    txthornome.Text = "";
                    txthornome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcestado.SelectedIndex = 0;
        }

        private void dvgestado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txthorcodi.Text = dvgestado.Rows[e.RowIndex].Cells["HORCODI"].Value.ToString();
            txtpaicodi_Leave(null, null);
            tbcestado.SelectedIndex = 1;
            txthornome.Focus();
            edicao = true;
            cbltip.SelectedItem = Paises.FirstOrDefault(q=> q.Split('-')[0].Trim() == dvgestado.Rows[e.RowIndex].Cells["THCODI"].Value.ToString());
        }
    }
}
