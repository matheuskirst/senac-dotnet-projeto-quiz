using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Modelos.Questoes
{
    public class Questao
    {
        public int Id { get; set; }

        public int TemaId { get; set; }
        public QuestaoTema Tema { get; set; } = null!;

        public QuestaoNivelId NivelId { get; set; }
        public QuestaoNivel Nivel { get; set; } = null!;

        public QuestaoTipo Tipo { get; set; }

        public string Enunciado { get; set; } = null!;
        public bool? VerdadeiroFalso { get; set; }

        public ICollection<Alternativa> Alternativas { get; set; } = new List<Alternativa>();
        public ICollection<QuizDiario> Quizzes { get; set; } = new List<QuizDiario>();
        public ICollection<UsuarioResposta> UsuarioRespostas { get; set; } = new List<UsuarioResposta>();
    }
}
