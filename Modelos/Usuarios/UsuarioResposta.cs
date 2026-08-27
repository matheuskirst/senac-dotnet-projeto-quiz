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

        public bool Acertou { get; set; }
        public int QuestaoValor { get; set; }
        public int PontuacaoFinal { get; set; } = 0;
        public DateTime? DataDeResposta { get; set; } = DateTime.UtcNow;
    }
}
