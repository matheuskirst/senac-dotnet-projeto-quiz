using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Enums
{
    public class ErroAutenticacao
    {
        private ErroAutenticacao(string valor) { Valor = valor; }

        public string Valor { get; set; }

        public static ErroAutenticacao NomeIndisponivel { get; } = new("Esse nome não está disponível!");
        public static ErroAutenticacao LoginInvalido { get; } = new("Nome ou senha estão errados.");
    }
}
