using SenacQuizApp.Dtos.QuizDiario;
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

                LabelDataInicio.Text = resultado.DataIniciado.ToString(@"dd/MM/yyyy HH\:mm\:ss");
                LabelDataConcluido.Text = resultado.DataConcluido?.ToString(@"dd/MM/yyyy HH\:mm\:ss") ?? "Não disponível";
                LabelTempoDeConclusao.Text = resultado.TempoDeConclusao?.ToString(@"hh\:mm\:ss\.fff") ?? "Não disponível";
                LabelTotalQuestoes.Text = resultado.TotalQuestoes.ToString();
                LabelTotalAcertos.Text = resultado.TotalAcertos.ToString();
                LabelPontuacaoTotal.Text = resultado.PontuacaoTotal.ToString();


                foreach (QuestaoResultado questao in resultado.Questoes)
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
                        ColorScheme = AntdUI.TAMode.Dark,
                    };

                    collapse.Controls.Add(questaoEnunciado);

                }
            }
            catch
            {

            }
        }
    }
}
