using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;

namespace SenacQuizApp.Modelos
{
    public enum TipoPergunta
    {
        Alternativas,
        VerdadeiroOuFalso
    }

    public class OpcaoResposta
    {
        public string Text { get; set; } = string.Empty;
        public bool IsCorreta { get; set; }
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

        [StringLength(500)]
        public string Enunciado { get; set; }
        public TipoPergunta Tipo { get; set; }
        public List<OpcaoResposta> Respostas { get; set; } = new List<OpcaoResposta>();
        public NivelPergunta Nivel { get; set; }
        public TemaPergunta Tema { get; set; }

        public ICollection<QuizPerguntas> QuizPerguntas { get; set; } = new List<QuizPerguntas>();
        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();
    }
}
