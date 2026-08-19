using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Modelos
{
    public class Pergunta
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string Enunciado { get; set; } = null!;
        public int TemaId { get; set; }
        public PerguntaTema Tema { get; set; } = null!;
        public PerguntaTipo Tipo { get; set; }
        public PerguntaNivel Nivel { get; set; }

        public ICollection<PerguntaAlternativa> Alternativas { get; set; } = new List<PerguntaAlternativa>();
        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();
    }
}
