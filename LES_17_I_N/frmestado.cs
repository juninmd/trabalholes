using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmestado : Form
    {
        public frmestado()
        {
            InitializeComponent();
        }
        public EstadoDao EstadoDao = new EstadoDao();
        public PaisDao PaisDao = new PaisDao();

        public List<string> Paises { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtestcodi.Clear(); // Limpa o textbox
            txtestnome.Clear(); // Limpa o textbox
            txtesticms.Clear(); // Limpa o textbox
            txtestuf.Clear(); // Limpa o textbox
            txtestcodi.Focus(); // Vai para o textbox código
            cblPais.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private EstadoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtestcodi.Text) ||
                String.IsNullOrEmpty(txtestnome.Text) ||
                String.IsNullOrEmpty(txtesticms.Text) ||
                String.IsNullOrEmpty(txtestuf.Text) ||
                (cblPais.SelectedItem) == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new EstadoModel
            {
                ESTCODI = int.Parse(txtestcodi.Text),
                ESTNOME = txtestnome.Text,
                ESTICMS = txtesticms.Text,
                ESTUF = txtestuf.Text,
                PAICODI = cblPais.Text.Split('-')[0]
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                EstadoDao.Update(entidade);
            else
            {
                EstadoDao.Insert(entidade);
            }

            limpar();
            txtestcodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            EstadoDao.Update(entidade);
            limpar();
            txtestcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtestcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            EstadoDao.Delete(int.Parse(txtestcodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = EstadoDao.GetAll();
            cblPais.Items.Clear();
            cblPais.Items.AddRange(Paises.ToArray());
            if (dt.Rows.Count > 0)
                dvgestado.DataSource = dt;
        }

        private void frmestado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmestado_Load(object sender, EventArgs e)
        {
            Paises = GetPaises();
            DgvDados();
        }

        private List<string> GetPaises()
        {
            var lista = new List<string>();
            var pais = PaisDao.GetAll();
            foreach (var item in pais.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["PAICODI"]} - {row["PAINOME"]}");
            }
            return lista;
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtestcodi.Text))
                return;

            var dr = EstadoDao.GetById(int.Parse(txtestcodi.Text));
            if (dr.Read())
            {
                txtestcodi.Text = dr["ESTCODI"].ToString();
                txtestnome.Text = dr["ESTNOME"].ToString();
                txtestuf.Text = dr["ESTUF"].ToString();
                txtesticms.Text = dr["ESTICMS"].ToString();
                cblPais.SelectedItem = Paises.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["PAICODI"].ToString());
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
                    txtestnome.Text = "";
                    txtestnome.Focus();
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
            txtestcodi.Text = dvgestado.Rows[e.RowIndex].Cells["ESTCODI"].Value.ToString();
            txtpaicodi_Leave(null, null);
            tbcestado.SelectedIndex = 1;
            txtestnome.Focus();
            edicao = true;
            cblPais.SelectedItem = Paises.FirstOrDefault(q=> q.Split('-')[0].Trim() == dvgestado.Rows[e.RowIndex].Cells["PAICODI"].Value.ToString());
        }
    }
}
