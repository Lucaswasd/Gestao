using Models;
using BLL;
using System.Net.Mail;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                //char opclaco;
                string opclaco;
                do
                {
                    Console.WriteLine("Informe o nome do usuário:");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o Apelido(Nome de usuário): ");
                    usuario.NomeUsuario = Console.ReadLine();
                    Console.WriteLine("O usuário está Ativo? [S]-Sim ou [N]-Não");
                    char opcinativo = Convert.ToChar(Console.ReadLine());

                    if (opcinativo != 's')
                        usuario.Ativo = true;
                            else usuario.Ativo = false;
                            
                    Console.WriteLine("Informe o email do usuário");
                    usuario.Email = Console.ReadLine();
                    Console.WriteLine("Informe o CPF: ");
                    usuario.CPF = Console.ReadLine();
                    Console.WriteLine("Informe a senha do usuário: ");
                    usuario.Senha = Console.ReadLine();

                    Console.WriteLine("Deseja continuar? [S]-Sim ou [N]-Não");

                    opclaco = Console.ReadLine();
                } while (opclaco == "");

                usuarioBLL.Inserir(usuario);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}