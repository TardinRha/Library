using Library.Classes;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

internal class Program
{
    public static void Main(string[] args)
    {
        int condicao = 0;
        int modulo = 0;
        int opcaoUsuario = 0;
        int opcaoAdministrador = 0;

        var usuario = new Usuario();
        Console.WriteLine("Bem vindo(a) ao Backlog");
        usuario.AdicionarLivroNoSistema();
        usuario.EditarInformacaoDeLivro();
        //while (condicao != 9)
        //{
        //    if (modulo == 0)
        //    {
        //        Console.WriteLine("Bem vindo ao modulo ADMINISTRADOR!");
        //        Console.WriteLine("Selecione uma opção a seguir:");
        //        Console.WriteLine("0 - Trocar de Módulo");
        //        Console.WriteLine("1 - Cadastrar Usuário");
        //        Console.WriteLine("2 - Cadastrar Livro");
        //    }
        //    if (modulo == 1)
        //    {
        //        Console.WriteLine("Bem vindo ao modulo USUÁRIO!");
        //        Console.WriteLine("Selecione uma opção a seguir:");
        //        Console.WriteLine("0 - Trocar de Módulo");
        //        Console.WriteLine("1 - Ver lista de 'livros lidos'");
        //        Console.WriteLine("2 - Ver lista de 'livros que quero ler'");
        //        Console.WriteLine("3 - Ver lista de 'livros abandonados'");
        //        Console.WriteLine("4 - Adicionar livros na 'estante pessoal'");
        //        Console.WriteLine("5 - Ver livros na 'estante pessoal'");


        //    }
        //}
    }
}