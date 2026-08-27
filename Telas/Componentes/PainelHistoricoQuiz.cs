using System.ComponentModel;
using SenacQuizApp.Dtos.QuizDiario.Historico;

namespace SenacQuizApp.Telas.Componentes.Quiz
{
    public partial class PainelHistoricoQuiz : UserControl
    {
        private readonly List<QuizDiarioHistorico> _quizzes;
        private readonly BindingList<QuizDiarioHistorico> _quizList = [];
        public PainelHistoricoQuiz(List<QuizDiarioHistorico> quizzes)
        {
            _quizzes = quizzes;

            InitializeComponent();

            TableQuizHistorico.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataExibido), "Data Exibido"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataInicio), "Data Iniciado"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.FoiConcluido), "Concluído"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataConcluido), "Data Concluído"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TempoDeConclusao), "Tempo para concluir"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TotalQuestoes), "Total Questões"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TotalAcertos), "Acertos"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.PontuacaoTotal), "Pontuação Final"),
            };
        }

        private void PainelHistórico_Load(object sender, EventArgs e)
        {
            TableQuizHistorico.DataSource = _quizList;
            AtualizarTabelaQuizzes();
        }

        private void AtualizarTabelaQuizzes()
        {
            TableQuizHistorico.PauseLayout = true;
            try
            {
                _quizList.Clear();

                foreach (QuizDiarioHistorico quiz in _quizzes)
                {
                    _quizList.Add(quiz);
                }
            }
            finally
            {
                TableQuizHistorico.PauseLayout = false;
                TableQuizHistorico.Refresh();
            }
        }
    }
}
