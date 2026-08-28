using System.ComponentModel;
using SenacQuizApp.Dtos.QuizDiario.Historico;

namespace SenacQuizApp.Telas.Componentes.Quiz
{
    public partial class HistoricoQuizDiario : UserControl
    {
        private readonly BindingList<QuizDiarioHistorico> _quizList = [];
        public HistoricoQuizDiario(List<QuizDiarioHistorico> quizzes)
        {
            InitializeComponent();

            TableQuizHistorico.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizDiarioHistorico.Tipo), "Tipo"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataExibido), "Data Exibido"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataIniciado), "Data Iniciado"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.Concluido), "Concluído"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataConcluido), "Data Concluído"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TempoDeConclusao), "Tempo para concluir"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TotalQuestoes), "Total Questões"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TotalAcertos), "Acertos"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.PontuacaoTotal), "Pontuação Final"),
            };
            TableQuizHistorico.DataSource = _quizList;
        }

        public void AtualizarTabelaQuizzes(List<QuizDiarioHistorico> quizzes)
        {
            TableQuizHistorico.PauseLayout = true;
            try
            {
                _quizList.Clear();

                foreach (QuizDiarioHistorico quiz in quizzes)
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
