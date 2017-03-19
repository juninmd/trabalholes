using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class BairroDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM BAIRRO WHERE BAICODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM BAIRRO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(BairroModel entidade)
    	{
    	 	var sql = $"INSERT INTO BAIRRO VALUES"
    		+$"({entidade.BAICODI}"
    		+$"{entidade.BAINOME},"
    		+$"{entidade.MUNCODI})";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(BairroModel entidade)
    	{
    	 	var sql = $"UPDATE BAIRRO SET " 
    		+$"BAICODI = {entidade.BAICODI},"
    		+$"BAINOME = {entidade.BAINOME},"
    		+$"MUNCODI = {entidade.MUNCODI} "
    	 	+$"WHERE BAICODI = { entidade.BAICODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM BAIRRO WHERE BAICODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}