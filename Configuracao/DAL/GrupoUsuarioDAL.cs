using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void RemoverTodasPermissoes(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM UsuarioGrupoUsuario WHERE IdGrupoUsuario = @IdGrupoUsuario"))
                {
                    cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                    if (transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                }
            }
        }

        public void Ecluir(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"DELETE FROM GrupoUsuario WHERE id = @id", cn))
                {
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@Id", _idGrupoUsuario);

                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    RemoverTodasPermissoes(_idGrupoUsuario, transaction);
                    RemoverTodosUsuarios(_idGrupoUsuario, transaction);
                    cmd.ExecuteNonQuery();
                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir o grupo de usuário no banco de dados: " + ex.Message);
                    }
                }
            }
        }

        private void RemoverTodosUsuarios(int idGrupoUsuario, SqlTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}






