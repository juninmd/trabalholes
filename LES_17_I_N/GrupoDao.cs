using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class GrupoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM GRUPO WHERE GRUCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM GRUPO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(GrupoModel entidade)
    	{
    	 	var sql = $"INSERT INTO GRUPO (GRUCODI,GRUNOME) VALUES"
    		+$"('{entidade.GRUCODI}',"
    		+$"'{entidade.GRUNOME}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(GrupoModel entidade)
    	{
    	 	var sql = $"UPDATE GRUPO SET " 
    		+$"GRUCODI = '{entidade.GRUCODI}',"
    		+$"GRUNOME = '{entidade.GRUNOME}' "
    	 	+$"WHERE GRUCODI = { entidade.GRUCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM GRUPO WHERE GRUCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}