using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Telas.Eventos
{
    public class SignupEventArgs(string nome, string nick, DateTime? dataNascimento, string senha) : EventArgs
    {
        public string Nome { get; set; } = nome;
        public string Nick { get; set; } = nick;
        public DateTime? DataNascimento { get; set; } = dataNascimento;
        public string Senha { get; set; } = senha;
    }
}
