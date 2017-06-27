using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class ProdutoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM PRODUTO WHERE PROCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	
    	 	var sql = $"SELECT * FROM PRODUTO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(ProdutoModel entidade)
    	{
    	 	var sql = $"INSERT INTO PRODUTO (PROCODI,PRONOME,PROCUST,PROMARG,PROVEND,PROESTO,PROLOCA,PROOBS,UNICODI,GRUCODI) VALUES"
    		+$"('{entidade.PROCODI}',"
    		+$"'{entidade.PRONOME}',"
    		+$"'{entidade.PROCUST}',"
    		+$"'{entidade.PROMARG}',"
    		+$"'{entidade.PROVEND}',"
    		+$"'{entidade.PROESTO}',"
    		+$"'{entidade.PROLOCA}',"
    		+$"'{entidade.PROOBS}',"
    		+$"'{entidade.UNICODI}',"
    		+$"'{entidade.GRUCODI}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(ProdutoModel entidade)
    	{
    	 	var sql = $"UPDATE PRODUTO SET " 
    		+$"PROCODI = '{entidade.PROCODI}',"
    		+$"PRONOME = '{entidade.PRONOME}',"
    		+$"PROCUST = '{entidade.PROCUST}',"
    		+$"PROMARG = '{entidade.PROMARG}',"
    		+$"PROVEND = '{entidade.PROVEND}',"
    		+$"PROESTO = '{entidade.PROESTO}',"
    		+$"PROLOCA = '{entidade.PROLOCA}',"
    		+$"PROOBS = '{entidade.PROOBS}',"
    		+$"UNICODI = '{entidade.UNICODI}',"
    		+$"GRUCODI = '{entidade.GRUCODI}' "
    	 	+$"WHERE PROCODI = { entidade.PROCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM PRODUTO WHERE PROCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}