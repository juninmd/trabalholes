using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class ClienteDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM CLIENTE WHERE CLICODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM CLIENTE";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(ClienteModel entidade)
    	{
    	 	var sql = $"INSERT INTO CLIENTE (CLICODI,CLINOME,CLIFANT,CLIAPEL,CLILIMI,CLIDTIN,CLICNPJ,CLIINES,CLIEMAI,CLIFONE,CLICELU,CLICEL1,CLINUME,CLISTAT) VALUES"
    		+$"('{entidade.CLICODI}',"
    		+$"'{entidade.CLINOME}',"
    		+$"'{entidade.CLIFANT}',"
    		+$"'{entidade.CLIAPEL}',"
    		+$"'{entidade.CLILIMI}',"
    		+$"'{entidade.CLIDTIN}',"
    		+$"'{entidade.CLICNPJ}',"
    		+$"'{entidade.CLIINES}',"
    		+$"'{entidade.CLIEMAI}',"
    		+$"'{entidade.CLIFONE}',"
    		+$"'{entidade.CLICELU}',"
    		+$"'{entidade.CLICEL1}',"
    		+$"'{entidade.CLINUME}',"
    		+$"'{entidade.CLISTAT}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(ClienteModel entidade)
    	{
    	 	var sql = $"UPDATE CLIENTE SET " 
    		+$"CLICODI = '{entidade.CLICODI}',"
    		+$"CLINOME = '{entidade.CLINOME}',"
    		+$"CLIFANT = '{entidade.CLIFANT}',"
    		+$"CLIAPEL = '{entidade.CLIAPEL}',"
    		+$"CLILIMI = '{entidade.CLILIMI}',"
    		+$"CLIDTIN = '{entidade.CLIDTIN}',"
    		+$"CLICNPJ = '{entidade.CLICNPJ}',"
    		+$"CLIINES = '{entidade.CLIINES}',"
    		+$"CLIEMAI = '{entidade.CLIEMAI}',"
    		+$"CLIFONE = '{entidade.CLIFONE}',"
    		+$"CLICELU = '{entidade.CLICELU}',"
    		+$"CLICEL1 = '{entidade.CLICEL1}',"
    		+$"CLINUME = '{entidade.CLINUME}',"
    		+$"CLISTAT = '{entidade.CLISTAT}' "
    	 	+$"WHERE CLICODI = { entidade.CLICODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM CLIENTE WHERE CLICODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}