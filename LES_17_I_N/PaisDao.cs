﻿using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class PaisDao : FirebirdRepository
    {
        public void Insert(PAISModel entidade)
        {
            var sql = $"INSERT INTO PAIS VALUES('{entidade.PAICODI}','{entidade.PAINOME}')";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro incluído com sucesso !!!");
        }

        public void Update(PAISModel entidade)
        {
            var sql = $"UPDATE PAIS SET PAINOME = '{entidade.PAINOME}' WHERE PAICODI = {entidade.PAICODI}";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro gravado com sucesso !!!");
        }

        public void Delete(int ID)
        {
            var sql = $"DELETE FROM PAIS WHERE PAICODI = {ID}";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro excluído com sucesso !!!");
        }

        public IDataReader GetById(int ID)
        {
            var sql = $"SELECT * FROM PAIS WHERE PAICODI = {ID}";
            return ExecuteReader(sql);
        }

        public DataTable GetAll()
        {
            var datatable = new DataTable();
            var sql = $"SELECT * FROM PAIS";
            return ExecuteReaderDt(sql);
        }
    }
}
