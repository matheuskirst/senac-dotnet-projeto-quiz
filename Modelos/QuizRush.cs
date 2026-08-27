using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Modelos
{
    public class QuizRush
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }
        public Usuario Usuario { get; set; } = null!;

        public DateTime DataIniciado { get; set; } = DateTime.UtcNow;
        public DateTime? DataFinalizado { get; set; }
        public TimeSpan? TempoDeQuiz { get; set; }
        public int QuantidadeAcertos { get; set; }
        public int PontuacaoTotal { get; set; } = 0;

        public void Finalizar()
        {
            DataFinalizado = DateTime.UtcNow;
            TempoDeQuiz = DataFinalizado - DataIniciado;
        }
    }
}
