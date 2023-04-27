using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public string DataNascimento { get; set; }
        public DateTime Data { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Livro> LivrosCadastrados { get; set; } = new List<Livro>();
        public List<Livro> LivrosAbandonados { get; set; } = new List<Livro>();
        public List<Livro> LivrosLidos { get; set; } = new List<Livro>();
        public List<Livro> LivrosParaLer { get; set; } = new List<Livro>();
        public List<Livro> LivrosNaEstante { get; set; } = new List<Livro>();
        public List<Livro> LivrosFavoritos { get; set; } = new List<Livro>();
        public List<Livro> LivrosLendo { get; set; } = new List<Livro> { };

        public Usuario() {}

        public Usuario(string nome, DateTime dataNascimento, string login, string senha)
        {
            Id = Guid.NewGuid();
            ShortId = Id.ToString("N")[..6];//.Substring(0, 6)
            Nome = nome;
            Data = dataNascimento;
            DataNascimento = dataNascimento.ToString("dd/MM/yyyy");
            Login = login;
            Senha = senha;
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
                usuario.InformacaoUsuario();
            }
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
                            usuarioSelecionado.Data = DateTime.Parse(Console.ReadLine());
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
            Console.Write("Digite o ISBN do livro: ");
            string isbn = Console.ReadLine();
            Console.Write("Digite o Título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o Subtítulo do livro(se houver): ");
            string subtitulo = Console.ReadLine();
            Console.Write("Digite o nome do Autor Principal do livro: ");
            string autorPrincipal = Console.ReadLine();
            Console.Write("Digite o nome dos outros autores do livro separados por vírgula(se houver): ");
            List<string> outrosAutores = new();
            string[] autoresSecundarios = Console.ReadLine().Split(", ");
            foreach (string s in autoresSecundarios)
            {
                outrosAutores.Add(s);
            }
            Console.Write("Digite o nome da Editora do livro: ");
            string editora = Console.ReadLine();
            Console.Write("Digite o numero da edição do livro: ");
            string edicao = Console.ReadLine();
            Console.Write("Digite a(s) categoria(s) do livro separados por vírgula: ");
            List<string> categorias = new();
            string[] categ = Console.ReadLine().Split(", ");
            foreach (string c in categ)
            {
                categorias.Add(c);
            }
            Console.Write("Digite o texto de apresentação do livro: ");
            string texto = Console.ReadLine();
            Console.Write("Digite o nome da coleção do livro(se houver): ");
            string colecao = Console.ReadLine();
            Console.Write("Digite o volume do livro: ");
            string volume = Console.ReadLine();
            Console.Write("Digite a quantidade de páginas do livro: ");
            int paginas = int.Parse(Console.ReadLine());
            Console.Write("Qual o status do livro? 1-Lido; 2-Não lido; 3-Lendo; 4-Abandonado : ");
            int opcao = int.Parse(Console.ReadLine());
            string status;
            switch (opcao)
            {
                case 1:
                    {
                        status = "Lido";
                        break;
                    }
                case 2:
                    {
                        status = "Quero ler";
                        break;
                    }
                case 3:
                    {
                        status = "Lendo";
                        break;
                    }
                case 4:
                    {
                        status = "Abandonado";
                        break;
                    }
                default:
                    {
                        status = "Não lido";
                        break;
                    }
            }
            Livro livro = new(isbn, titulo, subtitulo, autorPrincipal, outrosAutores, editora, edicao, categorias, texto, colecao, volume, paginas, status);
            LivrosCadastrados.Add(livro);
            Console.WriteLine($"{livro.Titulo} adicionado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Deseja adicionar outro livro? s/n");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine();
                AdicionarLivroNoSistema();
            }
            Console.WriteLine();
        }
        public void RemoverLivroDoSistema()
        {
            MostrarLivrosCadastrados();
            Console.Write("Digite o ID do livro que deseja remover do sistema: ");
            string id = Console.ReadLine();
            Livro livroSelecionado = LivrosCadastrados.Find(l => l.ID == id);
            if (livroSelecionado == null)
            {
                Console.Write("ID INVÁLIDA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    RemoverLivroDoSistema();
                }
            }
            else
            {
                LivrosCadastrados.Remove(livroSelecionado);
                Console.WriteLine("Livro removido com sucesso!");
                Console.WriteLine();
            }
        }
        public void EditarInformacaoDeLivro()
        {
            MostrarLivrosCadastrados();
            Console.Write("Digite o ID do livro que deseja editar alguma informação: ");
            string id = Console.ReadLine();
            Livro livroSelecionado = LivrosCadastrados.Find(l => l.ID == id);
            if (livroSelecionado != null)
            {
                Console.WriteLine("Qual informação deseja editar?");
                Console.WriteLine("1- ISBN");
                Console.WriteLine("2- Título");
                Console.WriteLine("3- Subtítulo");
                Console.WriteLine("4- Autor principal");
                Console.WriteLine("5- Lista de outros autores");
                Console.WriteLine("6- Editora");
                Console.WriteLine("7- Edição");
                Console.WriteLine("8- Lista de categorias");
                Console.WriteLine("9- Texto de apresentação");
                Console.WriteLine("10- Nome da coleção");
                Console.WriteLine("11- Volume do livro");
                Console.WriteLine("12- Quantidade de páginas");
                Console.WriteLine("13- Status do livro");
                Console.WriteLine("0- Sair");
                Console.Write("Digite a opção: ");
                int opcaoEditar = int.Parse(Console.ReadLine());
                switch (opcaoEditar)
                {
                    case 1:
                        {
                            Console.Write("Digite o ISBN correto do livro: ");
                            livroSelecionado.ISBN = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Digite o Título correto do livro: ");
                            livroSelecionado.Titulo = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Digite o Subtítulo correto do livro: ");
                            livroSelecionado.Subtitulo = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Digite o Autor Principal correto do livro: ");
                            livroSelecionado.AutorPrincipal = Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Digite os outros autores corretos separados por virgula: ");
                            string[] autores = Console.ReadLine().Split(",");
                            livroSelecionado.OutrosAutores.Clear();
                            foreach (string aut in autores)
                            {
                                livroSelecionado.OutrosAutores.Add(aut);
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Digite a Editora correta do livro: ");
                            livroSelecionado.Editora = Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Digite o Numero da Edição correto do livro: ");
                            livroSelecionado.NumeroEdicao = Console.ReadLine();
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Digite as categorias separadas por virgula: ");
                            string[] categorias = Console.ReadLine().Split(",");
                            livroSelecionado.Categoria.Clear();
                            foreach (string cat in categorias)
                            {
                                livroSelecionado.Categoria.Add(cat);
                            }
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Digite o Texto de Apresentação correto do livro: ");
                            livroSelecionado.TextoApresentacao = Console.ReadLine();
                            break;
                        }
                    case 10:
                        {
                            Console.Write("Digite o nome correto da Coleção do livro: ");
                            livroSelecionado.Colecao = Console.ReadLine();
                            break;
                        }
                    case 11:
                        {
                            Console.Write("Digite o Volume correto do livro: ");
                            livroSelecionado.Volume = Console.ReadLine();
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Digite a quantidade Páginas corretas do livro: ");
                            livroSelecionado.Paginas = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 13:
                        {
                            Console.Write("Qual o status do livro? 1-Lido; 2-Não lido; 3-Lendo; 4-Abandonado : ");
                            int opcaoStatus = int.Parse(Console.ReadLine());
                            switch (opcaoStatus)
                            {
                                case 1:
                                    {
                                        livroSelecionado.StatusLivro = "Lido";
                                        break;
                                    }
                                case 2:
                                    {
                                        livroSelecionado.StatusLivro = "Quero ler";
                                        break;
                                    }
                                case 3:
                                    {
                                        livroSelecionado.StatusLivro = "Lendo";
                                        break;
                                    }
                                case 4:
                                    {
                                        livroSelecionado.StatusLivro = "Abandonado";
                                        break;
                                    }
                                default:
                                    {
                                        livroSelecionado.StatusLivro = "Não lido";
                                        break;
                                    }
                            }
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        {
                            Console.Write("OPÇÃO INVÁLIDA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                            if (Console.ReadLine() == "s")
                            {
                                Console.WriteLine();
                                EditarInformacaoDeLivro();
                            }
                            break;
                        }
                }
                Console.WriteLine("Deseja voltar ao menu de Edição de Informação? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    EditarInformacaoDeLivro();
                }

            }
            else
            {
                Console.Write("ID INVÁLIDA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine();
                    EditarInformacaoDeLivro();
                }
            }
        }
        public void MostrarLivrosCadastrados()
        {
            Console.Write("Você deseja ver a lista ordenada por 1-Título ou 2-Autor?");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Lista ordenada por Título: ");
                        LivrosCadastrados.Sort((p1, p2) => p1.Titulo.CompareTo(p2.Titulo));
                        foreach (var livro in LivrosCadastrados)
                        {
                            Console.WriteLine($"ID: {livro.ID} - Titulo: {livro.Titulo} - {livro.Subtitulo} - Autor(a): {livro.AutorPrincipal}");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Lista ordenada por Autor: ");
                        LivrosCadastrados.Sort((p1, p2) => p1.AutorPrincipal.CompareTo(p2.AutorPrincipal));
                        foreach (var livro in LivrosCadastrados)
                        {
                            Console.WriteLine($"ID: {livro.ID} - Titulo: {livro.Titulo} - {livro.Subtitulo} - Autor(a): {livro.AutorPrincipal}");
                        }
                        break;
                    }
                default:
                    {
                        Console.Write("OPÇÃO INVÁLIDA! DESEJA TENTAR NOVAMENTE? (s/n): ");
                        if (Console.ReadLine() == "s")
                        {
                            Console.WriteLine();
                            MostrarLivrosCadastrados();
                        }
                        break;
                    }
            }
            Console.WriteLine();
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
                Console.WriteLine();
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
        public void AdicionarLivrosNasRespectivasListas()
        {
            foreach (var livro in LivrosCadastrados)
            {
                if (livro.StatusLivro == "Lido")
                {
                    LivrosLidos.Add(livro);
                }
                else if (livro.StatusLivro == "Quero ler")
                {
                    LivrosParaLer.Add(livro);
                }
                else if (livro.StatusLivro == "Lendo")
                {
                    LivrosLendo.Add(livro);
                }
                else if (livro.StatusLivro == "Abandonado")
                {
                    LivrosAbandonados.Add(livro);
                }
            }
        }
        public void AdicionarNaEstante()
        {

        }
        public void AdicionarFavoritos()
        {

        }
        public void MostrarLivrosNaEstante()
        {
            Console.Write("Livros na estante: ");
            foreach (var livroNaEstante in LivrosNaEstante)
            {
                Console.WriteLine($"ID: {livroNaEstante.ID} - Titulo: {livroNaEstante.Titulo} - {livroNaEstante.Subtitulo} - Autor(a): {livroNaEstante.AutorPrincipal}");
            }
            Console.WriteLine();
        }
        public void MostrarLivrosFavoritos()
        {
            Console.Write("Livros favoritos: ");
            foreach (var livroFavorito in LivrosFavoritos)
            {
                Console.WriteLine($"ID: {livroFavorito.ID} - Titulo: {livroFavorito.Titulo} - {livroFavorito.Subtitulo} - Autor(a): {livroFavorito.AutorPrincipal}");
            }
            Console.WriteLine();
        }
        

        public void InformacaoUsuario()
        {
            Console.WriteLine($"Id: {ShortId} - Usuario: {Nome} - Data de Nascimento: {DataNascimento}");
        }
    }
}
