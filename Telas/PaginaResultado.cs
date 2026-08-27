using SenacQuizApp.Dtos.Quiz.Historico;

namespace SenacQuizApp.Telas.Componentes.Quiz
{
    public partial class PaginaResultado : UserControl
    {
        private readonly QuizHistoricoDto _quiz;
        public PaginaResultado(QuizHistoricoDto quiz)
        {
            _quiz = quiz;

            InitializeComponent();
        }

        private void PainelResultado_Load(object sender, EventArgs e)
        {
            LabelDataInicio.Text = _quiz.DataInicio.ToString();
            LabelDataConcluido.Text = _quiz.DataConcluido.ToString();
            LabelTempoDeConclusao.Text = _quiz.TempoDeConclusao?.ToString(@"hh\:mm\:ss\.fff") ?? "Não disponível";
            LabelTotalQuestoes.Text = _quiz.TotalQuestoes.ToString();
            LabelTotalAcertos.Text = _quiz.TotalAcertos.ToString();
            LabelPontuacaoTotal.Text = _quiz.PontuacaoTotal.ToString();

            CollapseQuestoes.Items.Clear();

            foreach (QuestaoHistoricoDto questao in _quiz.Questoes)
            {
                int questaoNumero = _quiz.Questoes.IndexOf(questao) + 1;
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
    }
}
