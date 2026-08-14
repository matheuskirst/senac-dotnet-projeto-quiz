using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public enum TipoPergunta
    {
        Alternativas,
        VerdadeiroOuFalso
    }

    public class NivelPergunta
    {
        public int NivelPerguntaId { get; set; }

        [StringLength(30)]
        public string Nome { get; set; }
        public int Pontos { get; set; }
    }

    public class TemaPergunta
    {
        public int TemaPerguntaId { get; set; }
        [StringLength(30)]
        public string Nome { get; set; }
    }

    public class Pergunta
    {
        public int PerguntaId { get; set; }

        [StringLength(50)]
        public string Enunciado { get; set; }
        public TipoPergunta Tipo { get; set; }
        public JsonDocument Respostas { get; set; }
        public NivelPergunta Nivel { get; set; }
        public TemaPergunta Tema { get; set; }

        public List<PerguntaRespondida> PerguntasRespondidas { get; set; } = new();
    }
}
