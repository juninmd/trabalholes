using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class Pedido_itemDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM PEDIDO_ITEM WHERE PEDCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM PEDIDO_ITEM";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(Pedido_itemModel entidade)
    	{
    	 	var sql = $"INSERT INTO PEDIDO_ITEM (PEDCODI,ITECODI,PROCODI,ITEQTDE,ITEVALO,ITETOTA) VALUES"
    		+$"('{entidade.PEDCODI}',"
    		+$"'{entidade.ITECODI}',"
    		+$"'{entidade.PROCODI}',"
    		+$"'{entidade.ITEQTDE}',"
    		+$"'{entidade.ITEVALO}',"
    		+$"'{entidade.ITETOTA}')";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(Pedido_itemModel entidade)
    	{
    	 	var sql = $"UPDATE PEDIDO_ITEM SET " 
    		+$"PEDCODI = '{entidade.PEDCODI}',"
    		+$"ITECODI = '{entidade.ITECODI}',"
    		+$"PROCODI = '{entidade.PROCODI}',"
    		+$"ITEQTDE = '{entidade.ITEQTDE}',"
    		+$"ITEVALO = '{entidade.ITEVALO}',"
    		+$"ITETOTA = '{entidade.ITETOTA}' "
    	 	+$"WHERE PEDCODI = { entidade.PEDCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM PEDIDO_ITEM WHERE PEDCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}