

namespace DAL
{
    internal static class Conexao
    {
        public static string StringDeConexao
        { 
            get
            {
                return "Use ID=SA;Initial Catalog=Gestao;Data Source=.\\SQLEXPRESS2019A;Password=Senailab02";//. significa "máquina local"
                //return @"Use ID=SA;Initial Catalog=Gestao;Data Source=.\SQLEXPRESS2019A;Password=Senailab02"; @ diz exatamente o endereço que deverá ir
            }
        }
    }
}
