using Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDadosPermissao(1);
            ValidarDados
            //ValidarPermissao(11, 4);
            ValidarDados(_usuario, _confirmacaoDeSenha);

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Já existe um usuário  com este nome");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        private void ValidarPermissao(int _idPermissao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
                throw new Exception("Você não tem permissão para alterar.");
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public Usuario BuscarPorId(int _id)
        {

            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Email, Ativo, NomeUsuario
                                    FROM Usuario WHERE Id = @Id";


                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        //GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        //usuario.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario(usuario.Id);
                        //usuarios.Add(usuario);
                    }
                }
                return usuario;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar fazer busca de usuário por Nome de Usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);

        }

        private static void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

            if (_confirmacaoDeSenha != _usuario.Senha)
                throw new Exception("O campo senha e a confirmação de senha não são iguais.");
        }

        public void Excluir(int _id)
        //não implementado no usuarioDAL
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }

        public void AdicionarGrupo(int _idUsuario, int _idGrupoUsuario)
        //não implementado no usuarioDAL

        //copiar o "ExisteRelacionamento" do professor
        {
            ValidarPermissao(10);
            if (new UsuarioDAL().ExisteRelacionamento(_idUsuario, _idGrupoUsuario))
                return;

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.AdicionarGrupo(_idUsuario, _idGrupoUsuario);
        }

        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            new UsuarioDAL().RemoverGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
    }
}