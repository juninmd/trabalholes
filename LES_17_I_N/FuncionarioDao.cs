using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class FuncionarioDao : FirebirdRepository
    {

        public IDataReader GetById(int ID)
        {
            var sql = $"SELECT * FROM FUNCIONARIO WHERE FUNCODI = { ID }";
            return ExecuteReader(sql);
        }

        public IDataReader GetFullById(int ID)
        {
            var sql = $"SELECT F.FUNCODI, F.FUNNOME, F.FUNSALA," +
                "F.FUNDTNA, F.FUNCPF, H.HORCODI,                               " +
                "FU.FUNCCODI, D.DEPCODI,  F.FUNRG,                             " +
                "F.FUNFONE, F.FUNCELU, F.FUNCEL1, F.FUNNUME,                   " +
                "FU.FUNCNOME, H.HORNOME, E.ENDCEP, E.ENDENDE, D.DEPNOME,       " +
                "BAI.BAICODI, BAI.BAINOME,                                     " +
                "MUN.MUNCODI, MUN.MUNNOME,                                     " +
                "EST.ESTCODI, EST.ESTNOME,                                     " +
                "PAI.PAICODI, PAI.PAINOME                                      " +
                "FROM FUNCIONARIO AS F                                         " +
                "LEFT JOIN ENDERECO AS E ON E.ENDCEP = F.ENDCEP                " +
                "LEFT JOIN BAIRRO AS BAI ON BAI.BAICODI = E.BAICODI            " +
                "LEFT JOIN MUNICIPIO AS MUN ON MUN.MUNCODI = BAI.MUNCODI       " +
                "LEFT JOIN ESTADO AS EST ON EST.ESTCODI = MUN.ESTCODI          " +
                "LEFT JOIN PAIS AS PAI ON PAI.PAICODI = EST.PAICODI            " +
                "LEFT JOIN FUNCAO AS FU ON F.FUNCCODI = FU.FUNCCODI            " +
                "LEFT JOIN HORARIO AS H ON F.HORCODI = H.HORCODI               " +
                "LEFT JOIN DEPTO AS D ON F.DEPCODI = D.DEPCODI                 " +
                $"WHERE F.FUNCODI = {ID}";
            return ExecuteReader(sql);
        }

        public DataTable GetAll()
        {
            var datatable = new DataTable();
            var sql = $"SELECT * FROM FUNCIONARIO";
            return ExecuteReaderDt(sql);
        }

        public void Insert(FuncionarioModel entidade)
        {
            var sql = $"INSERT INTO FUNCIONARIO (FUNCODI,FUNNOME,FUNSALA,FUNDTNA,FUNCPF,FUNRG,FUNFONE,FUNCELU,FUNCEL1,FUNNUME,ENDCEP,FUNCCODI,HORCODI) VALUES"
           + $"('{entidade.FUNCODI}',"
           + $"'{entidade.FUNNOME}',"
           + $"'{entidade.FUNSALA}',"
           + $"'{entidade.FUNDTNA}',"
           + $"'{entidade.FUNCPF}',"
           + $"'{entidade.FUNRG}',"
           + $"'{entidade.FUNFONE}',"
           + $"'{entidade.FUNCELU}',"
           + $"'{entidade.FUNCEL1}',"
           + $"'{entidade.FUNNUME}',"
           + $"'{entidade.ENDCEP}',"
           + $"'{entidade.FUNCCODI}',"
           + $"'{entidade.HORCODI}')";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro inserido com sucesso !!!");
        }

        public void Update(FuncionarioModel entidade)
        {
            var sql = $"UPDATE FUNCIONARIO SET "
           + $"FUNCODI = '{entidade.FUNCODI}',"
           + $"FUNNOME = '{entidade.FUNNOME}',"
           + $"FUNSALA = '{entidade.FUNSALA}',"
           + $"FUNDTNA = '{entidade.FUNDTNA}',"
           + $"FUNCPF = '{entidade.FUNCPF}',"
           + $"FUNRG = '{entidade.FUNRG}',"
           + $"FUNFONE = '{entidade.FUNFONE}',"
           + $"FUNCELU = '{entidade.FUNCELU}',"
           + $"FUNCEL1 = '{entidade.FUNCEL1}',"
           + $"FUNNUME = '{entidade.FUNNUME}',"
           + $"ENDCEP = '{entidade.ENDCEP}',"
           + $"FUNCCODI = '{entidade.FUNCCODI}',"
           + $"HORCODI = '{entidade.HORCODI}' "
            + $"WHERE FUNCODI = { entidade.FUNCODI}";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro gravado com sucesso !!!");
        }

        public void Delete(int ID)
        {
            var sql = $"DELETE FROM FUNCIONARIO WHERE FUNCODI = { ID }";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro excluído com sucesso !!!");
        }
    }
}