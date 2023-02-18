using DAL;
using Models;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 10 || _permissao.Descricao.Length >= 50)
                throw new Exception("A descrição da permissão de usuário deve ter mais de 10 caracteres");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }

    }
}
