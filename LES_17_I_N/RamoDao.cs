using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class RamoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM RAMO WHERE RAMCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var sql = $"SELECT * FROM RAMO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(RamoModel entidade)
    	{
    	 	var sql = $"INSERT INTO RAMO (RAMCODI,RAMNOME,RAMOBSE) VALUES"
    		+$"('{entidade.RAMCODI}',"
    		+$"'{entidade.RAMNOME}',"
    		+$"'{entidade.RAMOBSE}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(RamoModel entidade)
    	{
    	 	var sql = $"UPDATE RAMO SET " 
    		+$"RAMCODI = '{entidade.RAMCODI}',"
    		+$"RAMNOME = '{entidade.RAMNOME}',"
    		+$"RAMOBSE = '{entidade.RAMOBSE}' "
    	 	+$"WHERE RAMCODI = { entidade.RAMCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM RAMO WHERE RAMCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}