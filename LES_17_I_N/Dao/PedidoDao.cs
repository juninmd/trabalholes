using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class PedidoDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM PEDIDO WHERE PEDCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var sql = $"SELECT * FROM PEDIDO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(PedidoModel entidade)
    	{
    	 	var sql = $"INSERT INTO PEDIDO (PEDCODI,PEDDTEM,PEDDTBA,PEDTOTA,PEDPERC,PEDDESC,PEDLIQU,PEDCOND,PEDOBS,CLICODI,FUNCODI) VALUES"
    		+$"('{entidade.PEDCODI}',"
    		+$"'{entidade.PEDDTEM:yyyy-MM-dd}',"
    		+$"'{entidade.PEDDTBA:yyyy-MM-dd}',"
    		+$"'{entidade.PEDTOTA.ToString().Replace(",", ".")}',"
    		+$"'{entidade.PEDPERC.ToString().Replace(",", ".")}',"
    		+$"'{entidade.PEDDESC.ToString().Replace(",", ".")}',"
    		+$"'{entidade.PEDLIQU.ToString().Replace(",", ".")}',"
    		+$"'{entidade.PEDCOND}',"
    		+$"'{entidade.PEDOBS}',"
    		+$"'{entidade.CLICODI}',"
    		+$"'{entidade.FUNCODI}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(PedidoModel entidade)
    	{
    	 	var sql = $"UPDATE PEDIDO SET " 
    		+$"PEDCODI = '{entidade.PEDCODI}',"
    		+$"PEDDTEM = '{entidade.PEDDTEM:yyyy-MM-dd}',"
    		+$"PEDDTBA = '{entidade.PEDDTBA:yyyy-MM-dd}',"
    		+$"PEDTOTA = '{entidade.PEDTOTA.ToString().Replace(",", ".")}',"
    		+$"PEDPERC = '{entidade.PEDPERC.ToString().Replace(",", ".")}',"
    		+$"PEDDESC = '{entidade.PEDDESC.ToString().Replace(",", ".")}',"
    		+$"PEDLIQU = '{entidade.PEDLIQU.ToString().Replace(",", ".")}',"
    		+$"PEDCOND = '{entidade.PEDCOND}',"
    		+$"PEDOBS = '{entidade.PEDOBS}',"
    		+$"CLICODI = '{entidade.CLICODI}',"
    		+$"FUNCODI = '{entidade.FUNCODI}' "
    	 	+$"WHERE PEDCODI = { entidade.PEDCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM PEDIDO WHERE PEDCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}