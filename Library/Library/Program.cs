using Library.Classes;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

internal class Program
{
    public static void Main(string[] args)
    {
        int modulo = 0;
        int opcaoUsuario;
        int opcaoAdministrador;

        var usuario = new Usuario();
        while (modulo != 3)
        {
            if (usuario.UsuarioLogado == null)
            {
                usuario.IniciarSistema();
            }
            if (usuario.UsuarioLogado.TipoConta == "Administrador")
            {
                modulo = 1;
            }
            else { modulo = 2; }

            if (modulo == 1)
            {
                Console.WriteLine("Selecione uma opção a seguir:");
                Console.WriteLine("1 - Cadastrar Usuário");
                Console.WriteLine("2 - Mostrar Usuarios Cadastrados");
                Console.WriteLine("3 - Editar informação do usuário");
                Console.WriteLine("4 - Deletar Usuário");
                Console.WriteLine("5 - Cadastrar Livro");
                Console.WriteLine("6 - Mostrar livros cadastrados");
                Console.WriteLine("7 - Editar informação do livro");
                Console.WriteLine("8 - Pesquisar livro");
                Console.WriteLine("9 - Deletar livro");
                Console.WriteLine("10 - Sair");
                Console.Write("Digite a opção: ");
                opcaoAdministrador = int.Parse(Console.ReadLine());
                if (opcaoAdministrador == 1)
                {
                    usuario.CriarUsuario();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 2)
                {
                    usuario.MostrarUsuarios();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 3)
                {
                    usuario.EditarUsuario();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 4)
                {
                    usuario.RemoverUsuario();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 5)
                {
                    usuario.CadastrarLivroNoSistema();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 6)
                {
                    usuario.MostrarLivrosCadastrados();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 7)
                {
                    usuario.EditarInformacaoDeLivro();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 8)
                {
                    usuario.PesquisarLivro();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 9)
                {
                    usuario.RemoverLivroDoSistema();
                    Console.WriteLine();
                }
                if (opcaoAdministrador == 10)
                {
                    modulo = 3;
                }
            }
            if (modulo == 2)
            {
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Mostrar livros cadastrados");
                Console.WriteLine("3 - Editar informação do livro");
                Console.WriteLine("4 - Pesquisar livro");
                Console.WriteLine("5 - Ver livros na estante");
                Console.WriteLine("6 - Ver livros favoritos");
                Console.WriteLine("7 - Ver livros lidos");
                Console.WriteLine("8 - Ver livros para ler");
                Console.WriteLine("9 - Ver livros abandonados");
                Console.WriteLine("10 - Ver páginas lidas");
                Console.WriteLine("11 - Sair");
                Console.Write("Digite a opção: ");
                opcaoUsuario = int.Parse(Console.ReadLine());
                if (opcaoUsuario == 1)
                {
                    usuario.CadastrarLivroNoSistema();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 2)
                {
                    usuario.MostrarLivrosCadastrados();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 3)
                {
                    usuario.EditarInformacaoDeLivro();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 4)
                {
                    usuario.PesquisarLivro();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 5)
                {
                    usuario.MostrarLivrosNaEstante();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 6)
                {
                    usuario.MostrarLivrosFavoritos();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 7)
                {
                    usuario.MostrarLivrosLidos();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 8)
                {
                    usuario.MostrarLivrosParaLer();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 9)
                {
                    usuario.MostrarLivrosAbandonados();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 10)
                {
                    usuario.MostrarPaginasLidas();
                    Console.WriteLine();
                }
                if (opcaoUsuario == 11)
                {
                    modulo = 3;
                }
            }
        }
    }
}