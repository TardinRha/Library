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
        public string DataLancamento { get; set; }
        public int Paginas { get; set; }
        public List<string> OutrosAutores { get; set; } = new List<string>();
        public List<string> Categoria { get; set; }

        public Livro(string isbn, string titulo, string subtitulo, string autorPrincipal,
            List<string> outrosAutores, string editora, string numeroEdicao, string dataLancamento,
            List<string> categoria, string textoApresentacao, string colecao,
            string volume, int paginas)
        {
            ISBN = isbn;
            ID = isbn.Substring(1, 10);
            Titulo = titulo;
            Subtitulo = subtitulo;
            AutorPrincipal = autorPrincipal;
            OutrosAutores = outrosAutores;
            Editora = editora;
            NumeroEdicao = numeroEdicao;
            DataLancamento = dataLancamento;
            Categoria = categoria;
            TextoApresentacao = textoApresentacao;
            Colecao = colecao;
            Volume = volume;
            Paginas = paginas;
        }
        public void InformacaoLivro()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"{Titulo} - {Subtitulo}");
            Console.Write($"Autor: {AutorPrincipal} - ");
            foreach (var autor in OutrosAutores)
            {
                Console.Write(autor + ", ");
            }
            Console.WriteLine();
            Console.Write($"Editora: {Editora} - Edição: {NumeroEdicao} - Categoria: ");
            foreach (var categoria in Categoria)
            {
                Console.Write(categoria + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"Coletânea: {Colecao} - Volume: {Volume} - Páginas: {Paginas}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Sobre o livro: {TextoApresentacao}");
            Console.WriteLine($"Status do livro: {StatusLivro}");
            Console.WriteLine();
        }
    }
}
