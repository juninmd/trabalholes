using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class EstadoDao : FirebirdRepository
    {
        public void Insert(EstadoModel entidade)
        {
            var sql = $"INSERT INTO Estado VALUES('{entidade.ESTCODI}','{entidade.ESTICMS}')";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro incluído com sucesso !!!");
        }

        public void Update(EstadoModel entidade)
        {
          
        }

        public void Delete(int ID)
        {
            var sql = $"DELETE FROM Estado WHERE PAICODI = {ID}";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro excluído com sucesso !!!");
        }

        public IDataReader GetById(int ID)
        {
            var sql = $"SELECT * FROM Estado WHERE PAICODI = {ID}";
            return ExecuteReader(sql);
        }

        public DataTable GetAll()
        {
            var datatable = new DataTable();
            var sql = $"SELECT * FROM Estado";
            return ExecuteReaderDt(sql);
        }
    }
}
