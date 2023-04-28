using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string AutorPrincipal { get; set; }
        public string Editora { get; set; }
        public string NumeroEdicao { get; set; }
        public string TextoApresentacao { get; set; }
        public string? Colecao { get; set; }
        public string Volume { get; set; }
        public string ISBN { get; set; }
        public string ID { get; set; }
        public string StatusLivro { get; set; }
        public int Paginas { get; set; }
        public int PaginasLidas { get; set; } = 0;
        public List<string> OutrosAutores { get; set; } = new List<string>();
        public List<string> Categoria { get; set; }

        public Livro(string isbn, string titulo, string subtitulo, string autorPrincipal, 
            List<string> outrosAutores, string editora, string numeroEdicao, 
            List<string> categoria, string textoApresentacao, string colecao, 
            string volume, int paginas, string statuslivro)
        {
            ISBN = isbn;
            ID = isbn.Substring(12, 15);
            Titulo = titulo;
            Subtitulo = subtitulo;
            AutorPrincipal = autorPrincipal;
            OutrosAutores = outrosAutores;
            Editora = editora;
            NumeroEdicao = numeroEdicao;
            Categoria = categoria;
            TextoApresentacao = textoApresentacao;
            Colecao = colecao;
            Volume = volume;
            Paginas = paginas;
            StatusLivro = statuslivro;
        }
        public void MostrarPaginasLidas()
        {
            if (StatusLivro == "Lido")
            {
                PaginasLidas += Paginas;
            }
            Console.WriteLine(PaginasLidas);
        }
        public void InformacaoLivro()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"{Titulo} - {Subtitulo}");
            Console.WriteLine($"Autor: {AutorPrincipal} - {OutrosAutores}");
            Console.WriteLine($"Editora: {Editora} - Edição: {NumeroEdicao} - Categoria: {Categoria}");
            Console.WriteLine($"Coletânea: {Colecao} - Volume: {Volume} - Páginas: {Paginas}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Sobre o livro: {TextoApresentacao}");
            Console.WriteLine($"Status do livro: {StatusLivro}");
            Console.WriteLine();
        }
    }
}
