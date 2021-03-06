using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class TipohorarioDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM TIPOHORARIO WHERE THCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	
    	 	var sql = $"SELECT * FROM TIPOHORARIO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(TipohorarioModel entidade)
    	{
    	 	var sql = $"INSERT INTO TIPOHORARIO (THCODI,THNOME) VALUES"
    		+$"('{entidade.THCODI}',"
    		+$"'{entidade.THNOME}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(TipohorarioModel entidade)
    	{
    	 	var sql = $"UPDATE TIPOHORARIO SET " 
    		+$"THCODI = '{entidade.THCODI}',"
    		+$"THNOME = '{entidade.THNOME}' "
    	 	+$"WHERE THCODI = { entidade.THCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM TIPOHORARIO WHERE THCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}