using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Entidades
{
    public class Pergunta
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string Enunciado { get; set; } = string.Empty;
        public int TemaId { get; set; }
        public PerguntaTema Tema { get; set; } = null!;
        public PerguntaTipo Tipo { get; set; }
        public PerguntaNivel Nivel { get; set; }

        public ICollection<Alternativa> Alternativas { get; set; } = new List<Alternativa>();
        public ICollection<QuizPergunta> QuizPerguntas { get; set; } = new List<QuizPergunta>();
        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();
    }
}
