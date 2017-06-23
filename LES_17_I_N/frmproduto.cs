using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmproduto : Form
    {
        public frmproduto()
        {
            InitializeComponent();
        }

        public ProdutoDao ProdutoDao = new ProdutoDao();
        public EnderecoDao EnderecoDao = new EnderecoDao();
        public RamoDao RamoDao = new RamoDao();

        public bool edicao { get; set; }

        public List<string> Ramos { get; set; }

        private void limpar()
        {
            
            edicao = false;
            DgvDados();
        }

        private ProdutoModel Entidade()
        {
          return new ProdutoModel();
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                ProdutoDao.Update(entidade);
            else
            {
                ProdutoDao.Insert(entidade);
            }

            limpar();
         
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
             
        }

        private void DgvDados()
        {
            var dt = ProdutoDao.GetAll();

         
            dvgproduto.DataSource = dt;
        }

        private void frmproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }


        private void txtprodccodi_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcproduto.SelectedIndex = 0;
        }

        private void dvgproduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            Ramos = getRamos();
            DgvDados();
        }

        private List<string> getRamos()
        {
            var lista = new List<string>();
            var itens = RamoDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["RAMCODI"]} - {row["RAMNOME"]}");
            }
            return lista;
        }

        private void txtprodcep_Leave(object sender, EventArgs e)
        {
           

        }
        private void LimparCep()
        {
         
        }

    }
}
