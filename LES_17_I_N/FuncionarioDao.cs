using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class FuncionarioDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM FUNCIONARIO WHERE FUNCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM FUNCIONARIO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(FuncionarioModel entidade)
    	{
    	 	var sql = $"INSERT INTO FUNCIONARIO (FUNCODI,FUNNOME,FUNSALA,FUNDTNA,FUNCPF,FUNRG,FUNFONE,FUNCELU,FUNCEL1,FUNNUME,FUNCEP,FUNCCODI,HORCODI) VALUES"
    		+$"('{entidade.FUNCODI}',"
    		+$"'{entidade.FUNNOME}',"
    		+$"'{entidade.FUNSALA}',"
    		+$"'{entidade.FUNDTNA}',"
    		+$"'{entidade.FUNCPF}',"
    		+$"'{entidade.FUNRG}',"
    		+$"'{entidade.FUNFONE}',"
    		+$"'{entidade.FUNCELU}',"
    		+$"'{entidade.FUNCEL1}',"
    		+$"'{entidade.FUNNUME}',"
    		+$"'{entidade.FUNCEP}',"
    		+$"'{entidade.FUNCCODI}',"
    		+$"'{entidade.HORCODI}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(FuncionarioModel entidade)
    	{
    	 	var sql = $"UPDATE FUNCIONARIO SET " 
    		+$"FUNCODI = '{entidade.FUNCODI}',"
    		+$"FUNNOME = '{entidade.FUNNOME}',"
    		+$"FUNSALA = '{entidade.FUNSALA}',"
    		+$"FUNDTNA = '{entidade.FUNDTNA}',"
    		+$"FUNCPF = '{entidade.FUNCPF}',"
    		+$"FUNRG = '{entidade.FUNRG}',"
    		+$"FUNFONE = '{entidade.FUNFONE}',"
    		+$"FUNCELU = '{entidade.FUNCELU}',"
    		+$"FUNCEL1 = '{entidade.FUNCEL1}',"
    		+$"FUNNUME = '{entidade.FUNNUME}',"
    		+$"FUNCEP = '{entidade.FUNCEP}',"
    		+$"FUNCCODI = '{entidade.FUNCCODI}',"
    		+$"HORCODI = '{entidade.HORCODI}' "
    	 	+$"WHERE FUNCODI = { entidade.FUNCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM FUNCIONARIO WHERE FUNCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}