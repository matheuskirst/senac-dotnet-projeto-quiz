using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Modelos
{
    public class QuizRush
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }
        public Usuario Usuario { get; set; } = null!;

        public DateTimeOffset DataIniciado { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? DataFinalizado { get; set; }
        public TimeSpan? TempoDeQuiz { get; set; }
        public int QuantidadeAcertos { get; set; }
        public int PontuacaoTotal { get; set; } = 0;

        public void Finalizar()
        {
            DataFinalizado = DateTimeOffset.UtcNow;
            TempoDeQuiz = DataFinalizado - DataIniciado;
        }
    }
}
