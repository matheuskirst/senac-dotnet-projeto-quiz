using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizDiario.Resultado;
using SenacQuizApp.Services;

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
                QuizDiarioResultado? resultado = await _quizDiarioService.ObterResultadoPorId(_quizId);

                if (resultado == null) return;

                LabelDataInicio.Text = resultado.DataInicio.ToString();
                LabelDataConcluido.Text = resultado.DataConcluido.ToString();
                LabelTempoDeConclusao.Text = resultado.TempoDeConclusao?.ToString(@"hh\:mm\:ss\.fff") ?? "Não disponível";
                LabelTotalQuestoes.Text = resultado.TotalQuestoes.ToString();
                LabelTotalAcertos.Text = resultado.TotalAcertos.ToString();
                LabelPontuacaoTotal.Text = resultado.PontuacaoTotal.ToString();

                CollapseQuestoes.Items.Clear();

                foreach (QuizDiarioResultadoQuestao questao in resultado.Questoes)
                {
                    int questaoNumero = resultado.Questoes.IndexOf(questao) + 1;
                    AntdUI.CollapseItem collapse = new AntdUI.CollapseItem
                    {
                        Text = $"Questão {questaoNumero}"
                    };

                    AntdUI.Label questaoEnunciado = new AntdUI.Label
                    {
                        Text = questao.Enunciado,
                        TextMultiLine = true,
                        AutoSize = true,
                        Location = new Point(20, 20),
                        Width = CollapseQuestoes.Width - 40
                    };

                    collapse.Controls.Add(questaoEnunciado);

                    CollapseQuestoes.Items.Add(collapse);
                }

                CollapseQuestoes.Refresh();
            }
            catch
            {

            }
        }
    }
}
