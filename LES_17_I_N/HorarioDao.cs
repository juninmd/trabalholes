using System.Data;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public class HorarioDao : FirebirdRepository { 

    	public IDataReader GetById(int ID)
    	{
    	 	var sql = $"SELECT * FROM HORARIO WHERE HORCODI = { ID }";
    	 	return ExecuteReader(sql);
    	}

    	public DataTable GetAll()
    	{
    	 	var datatable = new DataTable();
    	 	var sql = $"SELECT * FROM HORARIO";
    	 	return ExecuteReaderDt(sql);
    	}

    	public void Insert(HorarioModel entidade)
    	{
    	 	var sql = $"INSERT INTO HORARIO VALUES"
    		+$"({entidade.HORCODI}"
    		+$"{entidade.HORNOME},"
    		+$"{entidade.HORMANE},"
    		+$"{entidade.HORMANS},"
    		+$"{entidade.HORTARE},"
    		+$"{entidade.HORTARS},"
    		+$"{entidade.THCODI})";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro inserido com sucesso !!!"); 
    	}

    	public void Update(HorarioModel entidade)
    	{
    	 	var sql = $"UPDATE HORARIO SET " 
    		+$"HORCODI = {entidade.HORCODI},"
    		+$"HORNOME = {entidade.HORNOME},"
    		+$"HORMANE = {entidade.HORMANE},"
    		+$"HORMANS = {entidade.HORMANS},"
    		+$"HORTARE = {entidade.HORTARE},"
    		+$"HORTARS = {entidade.HORTARS},"
    		+$"THCODI = {entidade.THCODI} "
    	 	+$"WHERE HORCODI = { entidade.HORCODI}"; 
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro gravado com sucesso !!!");
    	}

    	public void Delete(int ID)
    	{
    	 	var sql = $"DELETE FROM HORARIO WHERE HORCODI = { ID }";
    	 	ExecuteNonResult(sql); 
    	 	MessageBox.Show("Registro excluído com sucesso !!!"); 
    	}
    }
}