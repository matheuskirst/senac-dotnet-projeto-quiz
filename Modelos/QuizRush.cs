using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Modelos
{
    public class QuizRush
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }
        public Usuario Usuario { get; set; } = null!;

        public DateTimeOffset DataIniciado { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset DataConcluido { get; set; }
        public TimeSpan Tempo { get; set; }
        public int Streak { get; set; }
        public int PontuacaoTotal { get; set; } = 0;

        public void Finalizar()
        {
            DataConcluido = DateTimeOffset.UtcNow;
            Tempo = DataConcluido - DataIniciado;
        }
    }
}
