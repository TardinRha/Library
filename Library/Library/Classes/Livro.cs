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
        public string?[] OutrosAutores { get; set; } // vetor com split pq pode ser mais de 1. Separar por  ponto e virgula
        public string Editora { get; set; }
        public string NumeroEdicao { get; set; }
        public string[] Categoria { get; set; } //split tbm
        public string TextoApresentacao { get; set; }
        public string? Coletanea { get; set; }
        public string Volume { get; set; }
        public string ISBN { get; set; }
        public string ID { get; set; }
        public string? StatusLivro { get; set; }
        public int Paginas { get; set; }
        public int PaginasLidas { get; set; } = 0;

        public Livro() {}

        public Livro(string isbn, string titulo, string subtitulo, string autorPrincipal, 
            string?[] outrosAutores, string editora, string numeroEdicao, 
            string[] categoria, string textoApresentacao, string? coletanea, 
            string volume, int paginas, string? statuslivro)
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
            Coletanea = coletanea;
            Volume = volume;
            Paginas = paginas;
            StatusLivro = statuslivro;
        }
        public void InformacaoLivro()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"{Titulo} - {Subtitulo}");
            Console.WriteLine($"Autor: {AutorPrincipal} - {OutrosAutores}");
            Console.WriteLine($"Editora: {Editora} - Edição: {NumeroEdicao} - Categoria: {Categoria}");
            Console.WriteLine($"Coletânea: {Coletanea} - Volume: {Volume} - Páginas: {Paginas}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Sobre o livro: {TextoApresentacao}");
            Console.WriteLine($"Status do livro: {StatusLivro}");
            Console.WriteLine();
        }
    }
}
