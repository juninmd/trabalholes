using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class DeptoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM DEPTO WHERE DEPCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	
    	 	var sql = $"SELECT * FROM DEPTO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(DeptoModel entidade)
    	{
    	 	var sql = $"INSERT INTO DEPTO (DEPCODI,DEPNOME) VALUES"
    		+$"('{entidade.DEPCODI}',"
    		+$"'{entidade.DEPNOME}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(DeptoModel entidade)
    	{
    	 	var sql = $"UPDATE DEPTO SET " 
    		+$"DEPCODI = '{entidade.DEPCODI}',"
    		+$"DEPNOME = '{entidade.DEPNOME}' "
    	 	+$"WHERE DEPCODI = { entidade.DEPCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM DEPTO WHERE DEPCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}