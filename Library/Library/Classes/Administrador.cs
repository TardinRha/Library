using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Administrador
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Livro> Livros { get; set; } = new List<Livro>();

        public Administrador() { }

        public Administrador(string nome, string login, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
        public void AdicionarLivroNoSistema()
        {

        }
        public void RemoverLivroDoSistema()
        {

        }
        public void EditarInformacaoDeLivro()
        {

        }
        public void MostrarLivros()
        {

        }
        public void MostrarLivrosLidos()
        {

        }
        public void MostrarLivrosNaoLidos()
        {

        }
        public void CriarUsuario()
        {
            Console.Write("Digite o nome do usuario: ");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Digite a data de nascimento do usuario (00/00/0000): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o email que será o login do usuário: ");
            string emailUsuario = Console.ReadLine();
            Console.Write("Digite a senha do usuario: ");
            string senhaUsuario = Console.ReadLine();
            Usuario usuario = new(nomeUsuario, dataNascimento, emailUsuario, senhaUsuario);
            Usuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} criado com sucesso!");
            Console.WriteLine("Deseja adicionar outro usuário? s/n");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine();
                CriarUsuario();
            }
            Console.WriteLine();
        }
        public void MostrarUsuarios()
        {
            Console.WriteLine("Listagem de usuarios: ");
            foreach (Usuario usuario in Usuarios)
            {
                Console.WriteLine(usuario);
            }
            Console.WriteLine();
        }
        public void MostrarUsuarioEspecifico()
        {
            MostrarUsuarios();
            Console.Write("Digite o Id do usuario que deseja ver: ");
            string id = Console.ReadLine();
            Usuario usuarioSelecionado = Usuarios.Find(u => u.ShortId == id);
            Console.WriteLine(usuarioSelecionado);
            Console.WriteLine();
        }
        public void RemoverUsuario()
        {
            MostrarUsuarios();
            Console.Write("Digite o Id do usuario que deseja remover: ");
            string id = Console.ReadLine();
            Usuario usuarioSelecionado = Usuarios.Find(u => u.ShortId == id);
            if (usuarioSelecionado == null)
            {
                Console.Write("ID NÃO ENCONTRADA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    RemoverUsuario();
                }
            }
            else
            {
                Usuarios.Remove(usuarioSelecionado);
                Console.WriteLine("Usuario removido com sucesso!");
                Console.Write("Deseja remover outro? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    RemoverUsuario();
                }
            }
        }
        public void EditarUsuario()
        {
            MostrarUsuarios();
            Console.Write("Digite o Id do usuario que deseja editar: ");
            string id = Console.ReadLine();
            Usuario usuarioSelecionado = Usuarios.Find(u => u.ShortId == id);
            if (usuarioSelecionado != null)
            {
                Console.WriteLine("Qual informação do usuario deseja editar? ");
                Console.WriteLine("1- Nome; 2- Data de Nascimento; 3- Email/Login; 4- Senhha ");
                Console.Write("Digite a opção: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            usuarioSelecionado.Nome = Console.ReadLine();
                            break;
                        }
                        case 2:
                        {
                            usuarioSelecionado.DataNascimento = DateTime.Parse(Console.ReadLine());
                            break;
                        }
                        case 3:
                        {
                            usuarioSelecionado.Login = Console.ReadLine();
                            break;
                        }
                        case 4:
                        {
                            usuarioSelecionado.Senha = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.Write("OPÇÃO INVÁLIDA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                            if (Console.ReadLine() == "s")
                            {
                                Console.WriteLine();
                                EditarUsuario();
                            }
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("ID NÃO ENCONTRADA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    EditarUsuario();
                }
            }

        }




    }
}
