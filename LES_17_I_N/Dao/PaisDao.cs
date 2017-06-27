using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class PaisDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM PAIS WHERE PAICODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	
    	 	var sql = $"SELECT * FROM PAIS";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(PaisModel entidade)
    	{
    	 	var sql = $"INSERT INTO PAIS (PAICODI,PAINOME) VALUES"
    		+$"('{entidade.PAICODI}',"
    		+$"'{entidade.PAINOME}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(PaisModel entidade)
    	{
    	 	var sql = $"UPDATE PAIS SET " 
    		+$"PAICODI = '{entidade.PAICODI}',"
    		+$"PAINOME = '{entidade.PAINOME}' "
    	 	+$"WHERE PAICODI = { entidade.PAICODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM PAIS WHERE PAICODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}