using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class FuncaoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM FUNCAO WHERE FUNCCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM FUNCAO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(FuncaoModel entidade)
    	{
    	 	var sql = $"INSERT INTO FUNCAO (FUNCCODI,FUNCNOME,CBOCODI) VALUES"
    		+$"('{entidade.FUNCCODI}',"
    		+$"'{entidade.FUNCNOME}',"
    		+$"'{entidade.CBOCODI}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(FuncaoModel entidade)
    	{
    	 	var sql = $"UPDATE FUNCAO SET " 
    		+$"FUNCCODI = '{entidade.FUNCCODI}',"
    		+$"FUNCNOME = '{entidade.FUNCNOME}',"
    		+$"CBOCODI = '{entidade.CBOCODI}' "
    	 	+$"WHERE FUNCCODI = { entidade.FUNCCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM FUNCAO WHERE FUNCCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}