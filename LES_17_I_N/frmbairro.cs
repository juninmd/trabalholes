using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmbairro : Form
    {
        public frmbairro()
        {
            InitializeComponent();
        }
        public BairroDao BairroDao = new BairroDao();
        public MunicipioDao MunicipioDao = new MunicipioDao();

        public List<string> municipios { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtbaicodi.Clear(); // Limpa o textbox
            txtbainome.Clear(); // Limpa o textbox
            txtbaicodi.Focus(); // Vai para o textbox código
            cblmun.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private BairroModel Entidade()
        {
            if (String.IsNullOrEmpty(txtbaicodi.Text) ||
                String.IsNullOrEmpty(txtbainome.Text) ||
                (cblmun.SelectedItem) == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new BairroModel
            {
                BAICODI = int.Parse(txtbaicodi.Text),
                BAINOME = txtbainome.Text,
                MUNCODI = int.Parse(cblmun.Text.Split('-')[0])
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                BairroDao.Update(entidade);
            else
            {
                BairroDao.Insert(entidade);
            }

            limpar();
            txtbaicodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            BairroDao.Update(entidade);
            limpar();
            txtbaicodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbaicodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            BairroDao.Delete(int.Parse(txtbaicodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = BairroDao.GetAll();
            cblmun.Items.Clear();
            cblmun.Items.AddRange(municipios.ToArray());
            if (dt.Rows.Count > 0)
                dvgbairro.DataSource = dt;
        }

        private void frmbairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmbairro_Load(object sender, EventArgs e)
        {
            municipios = Getmunicipios();
            DgvDados();
        }

        private List<string> Getmunicipios()
        {
            var lista = new List<string>();
            var all = MunicipioDao.GetAll();
            foreach (var item in all.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["MUNCODI"]} - {row["MUNNOME"]}");
            }
            return lista;
        }

        private void txtbaicodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbaicodi.Text))
                return;

            var dr = BairroDao.GetById(int.Parse(txtbaicodi.Text));
            if (dr.Read())
            {
                txtbaicodi.Text = dr["BAICODI"].ToString();
                txtbainome.Text = dr["BAINOME"].ToString();
                cblmun.SelectedItem = municipios.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["MUNCODI"].ToString());
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
                    txtbainome.Text = "";
                    txtbainome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcbairro.SelectedIndex = 0;
        }

        private void dvgbairro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtbaicodi.Text = dvgbairro.Rows[e.RowIndex].Cells["BAICODI"].Value.ToString();
            txtbaicodi_Leave(null, null);
            tbcbairro.SelectedIndex = 1;
            txtbainome.Focus();
            edicao = true;
            cblmun.SelectedItem = municipios.FirstOrDefault(q => q.Split('-')[0].Trim() == dvgbairro.Rows[e.RowIndex].Cells["MUNCODI"].Value.ToString());
        }
    }
}
