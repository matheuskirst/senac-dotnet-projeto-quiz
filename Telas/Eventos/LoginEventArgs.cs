using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Telas.Eventos
{
    public class LoginEventArgs(string nome, string senha) : EventArgs
    {
        public string Nome { get; set; } = nome;
        public string Senha { get; set; } = senha;
    }
}
