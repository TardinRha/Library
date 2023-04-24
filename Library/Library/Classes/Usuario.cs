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
        public DateTime DataNascimento { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, DateTime dataNascimento, string login, string senha)
        {
            Id = Guid.NewGuid();
            ShortId = Id.ToString("N").Substring(0, 6);
            Nome = nome;
            Login = login;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
        
        public void MudarStatusLivro()
        {
            //lido, nao lidos, lendo, abandonado

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
