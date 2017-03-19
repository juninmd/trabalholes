using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class EnderecoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM ENDERECO WHERE ENDCEP = { ID }";
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
    	 	var sql = $"INSERT INTO ENDERECO VALUES"
    		+$"({entidade.ENDCEP}"
    		+$"{entidade.ENDENDE},"
    		+$"{entidade.BAICODI})";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(EnderecoModel entidade)
    	{
    	 	var sql = $"UPDATE ENDERECO SET " 
    		+$"ENDCEP = {entidade.ENDCEP},"
    		+$"ENDENDE = {entidade.ENDENDE},"
    		+$"BAICODI = {entidade.BAICODI} "
    	 	+$"WHERE ENDCEP = { entidade.ENDCEP}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM ENDERECO WHERE ENDCEP = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}