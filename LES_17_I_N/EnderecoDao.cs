using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class EnderecoDao : FirebirdRepository
    {

        public IDataReader GetById(string ID)
        {
            var sql = $"SELECT * FROM ENDERECO WHERE ENDCEP = '{ ID }'";
            return ExecuteReader(sql);
        }

        public IDataReader GetFullById(string ID)
        {
            var sql = $"SELECT E.ENDCEP, E.ENDENDE,         " +
            " BAI.BAICODI, BAI.BAINOME,                                " +
            " MUN.MUNCODI, MUN.MUNNOME,                                " +
            " EST.ESTCODI, EST.ESTNOME,                                " +
            " PAI.PAICODI, PAI.PAINOME                                 " +
            " FROM ENDERECO AS E                                       " +
            " LEFT JOIN BAIRRO AS BAI ON BAI.BAICODI = E.BAICODI       " +
            " LEFT JOIN MUNICIPIO AS MUN ON MUN.MUNCODI = BAI.MUNCODI  " +
            " LEFT JOIN ESTADO AS EST ON EST.ESTCODI = MUN.ESTCODI     " +
            " LEFT JOIN PAIS AS PAI ON PAI.PAICODI = EST.PAICODI       " +
            $" WHERE E.ENDCEP = '{ID}'";
            return ExecuteReader(sql);
        }

        public DataTable GetAll()
        {
            var datatable = new DataTable();
            var sql = $"SELECT * FROM ENDERECO";
            return ExecuteReaderDt(sql);
        }

        public void Insert(EnderecoModel entidade)
        {
            var sql = $"INSERT INTO ENDERECO (ENDCEP,ENDENDE,BAICODI) VALUES"
           + $"('{entidade.ENDCEP}',"
           + $"'{entidade.ENDENDE}',"
           + $"'{entidade.BAICODI}')";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro inserido com sucesso !!!");
        }

        public void Update(EnderecoModel entidade)
        {
            var sql = $"UPDATE ENDERECO SET "
           + $"ENDENDE = '{entidade.ENDENDE}',"
           + $"BAICODI = '{entidade.BAICODI}' "
            + $"WHERE ENDCEP = '{ entidade.ENDCEP}'";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro gravado com sucesso !!!");
        }

        public void Delete(string ID)
        {
            var sql = $"DELETE FROM ENDERECO WHERE ENDCEP = '{ ID }'";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro excluído com sucesso !!!");
        }
    }
}