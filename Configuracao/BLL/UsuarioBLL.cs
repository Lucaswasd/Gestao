﻿using DAL;
using Models;
namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if(_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter no mínimo x e x caracteres");

            //TODO: Validar se já existe um usário com este nome.

            UsuarioDAL usuarioDAL = new UsuarioDAL();
        }
        public Usuario Buscar(string _nomeUsuario)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)
        {

        }
    }
}