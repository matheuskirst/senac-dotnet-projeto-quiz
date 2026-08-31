using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioResposta
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public int QuizId { get; set; }
        public QuizDiario Quiz { get; set; } = null!;

        public int QuestaoId { get; set; }
        public Questao Questao { get; set; } = null!;

        public int? AlternativaId { get; set; }
        public Alternativa? Alternativa { get; set; }

        public bool? VerdadeiroFalso { get; set; }

        public bool Acertou { get; set; }
        public int QuestaoValor { get; set; }
        public int PontuacaoFinal { get; set; } = 0;
        public DateTimeOffset DataDeResposta { get; set; } = DateTimeOffset.UtcNow;
    }
}
