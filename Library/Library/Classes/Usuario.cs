using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string login, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
    }
}
