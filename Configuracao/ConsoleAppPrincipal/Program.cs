using Models;
using BLL;
using System.Net.Mail;
using System;

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
                //criando o objeto permissao
                Permissao permissao = new Permissao(); 
                string opclaco;
                int i = 1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Informe o nome do " + i + "° usuário desta sessão:");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Informe o Apelido(Nome de usuário): ");
                    usuario.NomeUsuario = Console.ReadLine();

                    Console.WriteLine("O usuário está Ativo? [S]-Sim ou [N]-Não");
                    char opcinativo = Convert.ToChar(Console.ReadLine()); //ToUpper() converte tudo para maiúsculo

                    if (opcinativo != 's' || opcinativo != 'S')
                        usuario.Ativo = true;
                            else usuario.Ativo = false;
                            
                    Console.WriteLine("Informe o email do usuário");
                    usuario.Email = Console.ReadLine();

                    Console.WriteLine("Informe o CPF: ");
                    usuario.CPF = Console.ReadLine();

                    Console.WriteLine("Informe a senha do usuário: ");
                    usuario.Senha = Console.ReadLine();

                    Console.WriteLine("Deseja continuar? [S]-Sim ou [N]-Não\n");
                    opclaco = Console.ReadLine();
                    Console.WriteLine("\n");

                    usuarioBLL.Inserir(usuario);
                    i++;
                } while (opclaco == "S" || opclaco == "s");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}