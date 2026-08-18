using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Telas.Eventos
{
    public class LoginEventArgs(string username, string senha) : EventArgs
    {
        public string Username { get; set; } = username;
        public string Senha { get; set; } = senha;
    }
}
