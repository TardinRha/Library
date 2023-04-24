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
        public string[] Autor { get; set; } // vetor com split pq pode ser mais de 1. Separar por  ponto e virgula
        public string Editora { get; set; }
        public string NumeroEdicao { get; set; }
        public string[] Categoria { get; set; } //split tbm
        public string TextoApresentacao { get; set; }
        public string? Coletanea { get; set; }
        public string Volume { get; set; }
        public string ISBN { get; set; }
        public string? StatusLivro { get; set; }
        public int Paginas { get; set; }
        public int PaginasLidas { get; set; } = 0;

        public Livro()
        {
        }

        public Livro(string titulo, string subtitulo, string[] autor, string editora, string numeroEdicao, string[] categoria, string textoApresentacao, string? coletanea, string volume, string isbn, int paginas, string? statuslivro)
        {
            Titulo = titulo;
            Subtitulo = subtitulo;
            Autor = autor;
            Editora = editora;
            NumeroEdicao = numeroEdicao;
            Categoria = categoria;
            TextoApresentacao = textoApresentacao;
            Coletanea = coletanea;
            Volume = volume;
            ISBN = isbn;
            Paginas = paginas;
            StatusLivro = statuslivro;
        }
        public void InformacaoLivro()
        {
            Console.WriteLine($"{Titulo} - {Subtitulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Editora: {Editora} - Edição: {NumeroEdicao} - Categoria: {Categoria}");
            Console.WriteLine($"Coletânea: {Coletanea} - Volume: {Volume} - Páginas: {Paginas}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Sobre o livro: {TextoApresentacao}");
            Console.WriteLine($"Status do livro: {StatusLivro}");
            Console.WriteLine();
        }
    }
}
