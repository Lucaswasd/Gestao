using DAL;
using Models;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length <= 10 || _grupousuario.NomeGrupo.Length > 50)
                throw new Exception("A descriçção do Grupo de Usuário deve ter mais de 10 caracteres");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_grupousuario);
        }
    }
}
