using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class EstadoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM ESTADO WHERE ESTCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	
    	 	var sql = $"SELECT * FROM ESTADO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(EstadoModel entidade)
    	{
    	 	var sql = $"INSERT INTO ESTADO (ESTUF,PAICODI,ESTCODI,ESTICMS,ESTNOME) VALUES"
    		+$"('{entidade.ESTUF}',"
    		+$"'{entidade.PAICODI}',"
    		+$"'{entidade.ESTCODI}',"
    		+$"'{entidade.ESTICMS}',"
    		+$"'{entidade.ESTNOME}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(EstadoModel entidade)
    	{
    	 	var sql = $"UPDATE ESTADO SET " 
    		+$"ESTUF = '{entidade.ESTUF}',"
    		+$"PAICODI = '{entidade.PAICODI}',"
    		+$"ESTCODI = '{entidade.ESTCODI}',"
    		+$"ESTICMS = '{entidade.ESTICMS}',"
    		+$"ESTNOME = '{entidade.ESTNOME}' "
    	 	+$"WHERE ESTCODI = { entidade.ESTCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM ESTADO WHERE ESTCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}