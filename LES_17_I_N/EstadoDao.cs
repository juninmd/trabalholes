using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class EstadoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM ESTADO WHERE ESTUF = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM ESTADO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(EstadoModel entidade)
    	{
    	 	var sql = $"INSERT INTO ESTADO VALUES"
    		+$"({entidade.ESTUF}"
    		+$"{entidade.PAICODI},"
    		+$"{entidade.ESTCODI},"
    		+$"{entidade.ESTICMS},"
    		+$"{entidade.ESTNOME})";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(EstadoModel entidade)
    	{
    	 	var sql = $"UPDATE ESTADO SET " 
    		+$"ESTUF = {entidade.ESTUF},"
    		+$"PAICODI = {entidade.PAICODI},"
    		+$"ESTCODI = {entidade.ESTCODI},"
    		+$"ESTICMS = {entidade.ESTICMS},"
    		+$"ESTNOME = {entidade.ESTNOME} "
    	 	+$"WHERE ESTUF = { entidade.ESTUF}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM ESTADO WHERE ESTUF = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}