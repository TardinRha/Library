using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string ShortId { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Livro> LivrosCadastrados { get; set; } = new List<Livro>();
        public List<Livro> LivrosAbandonados { get; set; } = new List<Livro>();
        public List<Livro> LivrosLidos { get; set; } = new List<Livro>();
        public List<Livro> LivrosParaLer { get; set; } = new List<Livro>();
        public List<Livro> LivrosNaEstante { get; set; } = new List<Livro>();
        public List<Livro> LivrosFavoritos { get; set; } = new List<Livro>();

        public Usuario() {}

        public Usuario(string nome, DateTime dataNascimento, string login, string senha)
        {
            Id = Guid.NewGuid();
            ShortId = Id.ToString("N")[..6];//.Substring(0, 6)
            Nome = nome;
            Login = login;
            Senha = senha;
            DataNascimento = dataNascimento;
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
            Console.WriteLine();
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
                Console.WriteLine($"Nome: {usuario.Nome} - Login: {usuario.Login}");
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
        public void AdicionarLivroNoSistema()
        {
            //ISBN = isbn;
            //Titulo = titulo;
            //Subtitulo = subtitulo;
            //AutorPrincipal = autorPrincipal;
            //OutrosAutores = outrosAutores;
            //Editora = editora;
            //NumeroEdicao = numeroEdicao;
            //Categoria = categoria;
            //TextoApresentacao = textoApresentacao;
            //Coletanea = coletanea;
            //Volume = volume;
            //Paginas = paginas;
            //StatusLivro = statuslivro;
            Console.Write("Digite o ISBN do livro: ");
            string isbn = Console.ReadLine();
            Console.Write("Digite o Título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o Subtítulo do livro(se houver): ");
            string subtitulo = Console.ReadLine();
            Console.Write("Digite o nome do Autor Principal do livro: ");
            string autorPrincipal = Console.ReadLine();
            Console.Write("Digite o nome dos outros autores do livro separados por vírgula(se houver): ");
            List<string> outrosAutores = new List<string>();
            string[] autoresSecundarios = Console.ReadLine().Split(", ");
            foreach (string s in autoresSecundarios) 
            { 
                outrosAutores.Add(s); 
            }
            Usuario usuario = new(nomeUsuario, dataNascimento, emailUsuario, senhaUsuario);
            Usuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} criado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Deseja adicionar outro usuário? s/n");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine();
                CriarUsuario();
            }
            Console.WriteLine();
        }
        public void RemoverLivroDoSistema()
        {

        }
        public void EditarInformacaoDeLivro()
        {

        }
        public void MostrarLivrosCadastrados()
        {
            Console.Write("Você deseja ver a lista ordenada por 1-Título ou 2-Autor?");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Lista ordenada por Título: ");
                LivrosCadastrados.Sort((p1, p2) => p1.Titulo.CompareTo(p2.Titulo));
                foreach (var livro in LivrosCadastrados)
                {
                    Console.WriteLine($"ID: {livro.ID} - Titulo: {livro.Titulo} - {livro.Subtitulo} - Autor(a): {livro.AutorPrincipal}");
                }
            }
            if (int.Parse(Console.ReadLine()) == 2)
            {
                Console.WriteLine("Lista ordenada por Autor: ");
                LivrosCadastrados.Sort((p1, p2) => p1.AutorPrincipal.CompareTo(p2.AutorPrincipal));
                foreach (var livro in LivrosCadastrados)
                {
                    Console.WriteLine($"ID: {livro.ID} - Titulo: {livro.Titulo} - {livro.Subtitulo} - Autor(a): {livro.AutorPrincipal}");
                }
            }
            else
            {
                Console.Write("OPÇÃO INVÁLIDA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    MostrarLivrosCadastrados();
                }
            }
        }
        public void MostrarLivroEspecifico()
        {
            MostrarLivrosCadastrados();
            Console.Write("Digite o ID do livro que deseja ver as informações completas: ");
            string id = Console.ReadLine();
            Livro livro = LivrosCadastrados.Find(l => l.ID == id);
            if (livro == null)
            {
                Console.Write("ID NÃO ENCONTRADA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                if (Console.ReadLine() == "s") { MostrarLivroEspecifico(); }
            }
            else
            {
                livro.InformacaoLivro();
            }
        }
        public void MostrarLivrosLidos()
        {
            Console.Write("Livros lidos: ");
            foreach (var livroLido in LivrosLidos)
            {
                Console.WriteLine($"ID: {livroLido.ID} - Titulo: {livroLido.Titulo} - {livroLido.Subtitulo} - Autor(a): {livroLido.AutorPrincipal}");
            }
            Console.WriteLine();
        }
        public void MostrarLivrosParaLer()
        {
            Console.Write("Livros para ler: ");
            foreach (var livroParaLer in LivrosParaLer)
            {
                Console.WriteLine($"ID: {livroParaLer.ID} - Titulo: {livroParaLer.Titulo} - {livroParaLer.Subtitulo} - Autor(a): {livroParaLer.AutorPrincipal}");
            }
            Console.WriteLine();
        }
        public void MudarStatusLivro()
        {
            //Ao mudar status do livro, adicionar na lista conforme o status
            //lido, nao lidos, lendo, abandonado

        }
        public void AdicionarNaEstante()
        {

        }
        public void AdicionarFavoritos()
        {

        }

        public string InformacaoUsuario()
        {
            return ($"Id: {ShortId} - Usuario: {Nome} - Data de Nascimento: {DataNascimento}");
        }
    }
}
