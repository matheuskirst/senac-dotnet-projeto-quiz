using SenacQuizApp.Dtos.QuizDiario;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas.QuizDiario
{
    public partial class ResultadoQuizDiario : UserControl
    {
        private int _quizId;
        private readonly QuizDiarioService _quizDiarioService;

        public ResultadoQuizDiario(int quizId, QuizDiarioService quizDiarioService)
        {
            _quizId = quizId;
            _quizDiarioService = quizDiarioService;

            InitializeComponent();
        }

        private async void PainelResultado_Load(object sender, EventArgs e)
        {
            try
            {
                FlowPanelQuestoes.PauseLayout = true;

                QuizDiarioResultado? resultado = await _quizDiarioService.ObterResultadoPorId(_quizId);

                if (resultado == null) return;

                LabelDataInicio.Text = resultado.DataIniciado.ToString(@"dd/MM/yyyy HH\:mm\:ss");
                LabelDataConcluido.Text = resultado.DataConcluido?.ToString(@"dd/MM/yyyy HH\:mm\:ss") ?? "Não disponível";
                LabelTempoDeConclusao.Text = resultado.TempoDeConclusao?.ToString(@"hh\:mm\:ss\.fff") ?? "Não disponível";
                LabelTotalQuestoes.Text = resultado.TotalQuestoes.ToString();
                LabelTotalAcertos.Text = resultado.TotalAcertos.ToString();
                LabelPontuacaoTotal.Text = resultado.PontuacaoTotal.ToString();

                for (int i = resultado.Questoes.Count - 1; i >= 0; i--)
                {
                    QuestaoResultado questao = resultado.Questoes[i];

                    int questaoNumero = i + 1;
                    string questaoEnunciado = questao.Enunciado;

                    var cardQuestao = new CardQuestao(questaoNumero.ToString(), questao);

                    FlowPanelQuestoes.Controls.Add(cardQuestao);
                }
            }
            catch
            {

            }
            finally
            {
                FlowPanelQuestoes.PauseLayout = false;
            }
        }
    }
}
