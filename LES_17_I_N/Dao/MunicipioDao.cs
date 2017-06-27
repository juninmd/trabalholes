using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class MunicipioDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM MUNICIPIO WHERE MUNCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	
    	 	var sql = $"SELECT * FROM MUNICIPIO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(MunicipioModel entidade)
    	{
    	 	var sql = $"INSERT INTO MUNICIPIO (MUNCODI,MUNNOME,ESTCODI) VALUES"
    		+$"('{entidade.MUNCODI}',"
    		+$"'{entidade.MUNNOME}',"
    		+$"'{entidade.ESTCODI}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(MunicipioModel entidade)
    	{
    	 	var sql = $"UPDATE MUNICIPIO SET " 
    		+$"MUNCODI = '{entidade.MUNCODI}',"
    		+$"MUNNOME = '{entidade.MUNNOME}',"
    		+$"ESTCODI = '{entidade.ESTCODI}' "
    	 	+$"WHERE MUNCODI = { entidade.MUNCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM MUNICIPIO WHERE MUNCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}