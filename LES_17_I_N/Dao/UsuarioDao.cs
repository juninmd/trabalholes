using System;
using System.Data;
using System.Windows.Forms;
using LES_17_I_N.Model;

namespace LES_17_I_N.Dao
{
    public class UsuarioDao : FirebirdRepository
    {

        public IDataReader GetById(string ID)
        {
            var sql = $"SELECT * FROM USUARIO WHERE USUNOME = '{ ID }'";
            return ExecuteReader(sql);
        }

        public IDataReader GetById(string nome, string senha)
        {
            var sql = $"SELECT * FROM USUARIO WHERE USUNOME = '{ nome }' and USUSENHA = '{ senha }'";
            return ExecuteReader(sql);
        }

        public DataTable GetAll()
        {
            var sql = $"SELECT USUNOME, FUNCODI, USUNIVEL, USUDATA, USUQTDE, USUBLOQ FROM USUARIO";
            return ExecuteReaderDt(sql);
        }

        public void Insert(UsuarioModel entidade)
        {
            var sql = $"INSERT INTO USUARIO (USUNOME,FUNCODI,USUSENHA,USUNIVEL,USUDATA,USUQTDE,USUBLOQ) VALUES"
           + $"('{entidade.USUNOME}',"
           + $"'{entidade.FUNCODI}',"
           + $"'{entidade.USUSENHA}',"
           + $"'{entidade.USUNIVEL}',"
           + $"'{entidade.USUDATA:yyyy-MM-dd}',"
           + $"'10',"
           + $"'{entidade.USUBLOQ}')";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro inserido com sucesso !!!");
        }

        public void Update(UsuarioModel entidade)
        {
            var sql = $"UPDATE USUARIO SET "
           + $"USUNOME = '{entidade.USUNOME}',"
           + $"FUNCODI = '{entidade.FUNCODI}',"
           + $"USUSENHA = '{entidade.USUSENHA}',"
           + $"USUNIVEL = '{entidade.USUNIVEL}',"
           + $"USUDATA = '{entidade.USUDATA:yyyy-MM-dd}',"
           + $"USUBLOQ = '{entidade.USUBLOQ}' "
            + $"WHERE USUNOME = '{ entidade.USUNOME}'";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro gravado com sucesso !!!");

        }

        public void Bloquear(string USUNOME)
        {
            var sql = $"UPDATE USUARIO SET "
                      + $"USUBLOQ = 'S' "
                      + $"WHERE USUNOME = '{ USUNOME}'";
            ExecuteNonResult(sql);
        }

        public void AlterarSenha(UsuarioModel entidade)
        {
            var sql = $"UPDATE USUARIO SET "
                      + $"USUSENHA = '{entidade.USUSENHA}', "
                      + $"USUDATA = '{DateTime.Now:yyyy-MM-dd}' "
                      + $"WHERE USUNOME = '{ entidade.USUNOME}'";
            ExecuteNonResult(sql);
        }

        public void ChancesBloqueio(UsuarioModel entidade)
        {
            var sql = $"UPDATE USUARIO SET "
                      + $"USUQTDE = '{entidade.USUQTDE}' "
                      + $"WHERE USUNOME = '{ entidade.USUNOME}'";
            ExecuteNonResult(sql);
        }

        public void Delete(string ID)
        {
            var sql = $"DELETE FROM USUARIO WHERE USUNOME = '{ ID }'";
            ExecuteNonResult(sql);
            MessageBox.Show("Registro excluído com sucesso !!!");
        }
    }
}