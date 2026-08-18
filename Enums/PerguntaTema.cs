using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Enums
{
    public class PerguntaTema
    {
        public static readonly PerguntaTema Hardware = new(1, "Hardware");
        public static readonly PerguntaTema Programacao = new(2, "Programação");
        public static readonly PerguntaTema Redes = new(3, "Redes");
        public static readonly PerguntaTema SegurancaDigital = new(4, "Segurança Digital");
        public static readonly PerguntaTema SistemasOperacionais = new(5, "Sistemas Operacionais");
        public static readonly PerguntaTema FerramentasDeProdutividade = new(6, "Ferramentas de Produtividade");

        private PerguntaTema(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        private PerguntaTema() { }

        public int Id { get; private set; }
        public string? Nome { get; private set; }

        public static IEnumerable<PerguntaTema> List() =>
            new[] { Hardware, Programacao, Redes, SegurancaDigital, SistemasOperacionais, FerramentasDeProdutividade };
    }
}
