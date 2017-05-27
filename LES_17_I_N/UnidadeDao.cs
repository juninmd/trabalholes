using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class UnidadeDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM UNIDADE WHERE UNICODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM UNIDADE";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(UnidadeModel entidade)
    	{
    	 	var sql = $"INSERT INTO UNIDADE (UNICODI,UNINOME) VALUES"
    		+$"('{entidade.UNICODI}',"
    		+$"'{entidade.UNINOME}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(UnidadeModel entidade)
    	{
    	 	var sql = $"UPDATE UNIDADE SET " 
    		+$"UNICODI = '{entidade.UNICODI}',"
    		+$"UNINOME = '{entidade.UNINOME}' "
    	 	+$"WHERE UNICODI = { entidade.UNICODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM UNIDADE WHERE UNICODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}