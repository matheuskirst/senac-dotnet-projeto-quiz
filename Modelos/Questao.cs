using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Modelos
{
    public class Questao
    {
        public int Id { get; set; }

        public QuestaoTemaId TemaId { get; set; }
        public QuestaoTema Tema { get; set; } = null!;

        public QuestaoNivelId NivelId { get; set; }
        public QuestaoNivel Nivel { get; set; } = null!;

        public QuestaoTipoId TipoId { get; set; }
        public QuestaoTipo Tipo { get; set; } = null!;

        public string Enunciado { get; set; } = null!;
        public bool? Verdadeira { get; set; }

        public ICollection<Alternativa> Alternativas { get; set; } = new List<Alternativa>();
        public ICollection<QuizDiario> Quizzes { get; set; } = new List<QuizDiario>();
        public ICollection<UsuarioResposta> UsuarioRespostas { get; set; } = new List<UsuarioResposta>();
    }
}
