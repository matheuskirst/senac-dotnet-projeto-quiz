using SenacQuizApp.Dtos.Historico;
using SenacQuizApp.Services;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Telas.QuizRush
{
    public partial class ResultadoQuizRush : UserControl
    {
        private readonly int _quizId;
        private readonly QuizRushService _quizRushService;

        public ResultadoQuizRush(int quizId, QuizRushService quizRushService)
        {
            _quizId = quizId;
            _quizRushService = quizRushService;

            InitializeComponent();
        }

        private async void ResultadoQuizRush_Load(object sender, EventArgs e)
        {
            try
            {
                QuizRushEntrada? resultado = await _quizRushService.ObterResultadoPorId(_quizId);

                if (resultado == null) return;

                LabelDataInicio.Text = resultado.DataIniciado.ToString(@"dd/MM/yyyy HH\:mm\:ss");
                LabelDataConcluido.Text = resultado.DataConcluido?.ToString(@"dd/MM/yyyy HH\:mm\:ss") ?? "Não disponível";
                LabelTempo.Text = resultado.Tempo?.ToString(@"hh\:mm\:ss\.fff") ?? "Não disponível";
                LabelMotivoEncerrado.Text = resultado.MotivoEncerrado == RushMotivoEncerrado.RespostaErrada ? "Resposta errada." : "Tempo esgotado.";
                LabelStreak.Text = resultado.Streak.ToString();
                LabelPontuacaoTotal.Text = resultado.PontuacaoTotal.ToString();
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
