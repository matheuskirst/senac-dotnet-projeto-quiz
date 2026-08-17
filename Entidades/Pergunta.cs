using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;

namespace SenacQuizApp.Entidades
{
    public enum TipoPergunta
    {
        Alternativas,
        VerdadeiroOuFalso
    }

    public class NivelPergunta
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Nome { get; set; }
        public int Pontos { get; set; }
    }

    public class TemaPergunta
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
    }

    public class Pergunta
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string Enunciado { get; set; }
        public TemaPergunta Tema { get; set; }
        public TipoPergunta Tipo { get; set; }
        public NivelPergunta Nivel { get; set; }

        public ICollection<Alternativa> Alternativas { get; set; } = new List<Alternativa>();
        public ICollection<QuizPergunta> QuizPerguntas { get; set; } = new List<QuizPergunta>();
        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();
    }
}
