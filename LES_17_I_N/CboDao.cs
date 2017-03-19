using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class CboDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM CBO WHERE CBOCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM CBO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(CboModel entidade)
    	{
    	 	var sql = $"INSERT INTO CBO VALUES"
    		+$"({entidade.CBOCODI}"
    		+$"{entidade.CBONOME})";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(CboModel entidade)
    	{
    	 	var sql = $"UPDATE CBO SET " 
    		+$"CBOCODI = {entidade.CBOCODI},"
    		+$"CBONOME = {entidade.CBONOME} "
    	 	+$"WHERE CBOCODI = { entidade.CBOCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM CBO WHERE CBOCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}