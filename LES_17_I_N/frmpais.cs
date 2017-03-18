using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmpais : Form
    {
        public frmpais()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            txtpaicodi.Clear(); // Limpa o textbox
            txtpainome.Clear(); // Limpa o textbox
            txtpaicodi.Focus(); // Vai para o textbox código
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro incluído com sucesso !!!");
            this.limpar();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso !!!");
            this.limpar();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro excluído com sucesso !!!");
            this.limpar();
        }

        private void frmpais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }
    }
}
