using System.ComponentModel;
using SenacQuizApp.Dtos.Quiz.Historico;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas.Componentes.Quiz
{
    public partial class PainelHistoricoQuiz : UserControl
    {
        private readonly List<QuizHistoricoDto> _quizzes;
        private readonly BindingList<QuizHistoricoDto> _quizList = [];
        public PainelHistoricoQuiz(List<QuizHistoricoDto> quizzes)
        {
            _quizzes = quizzes;

            InitializeComponent();

            TableQuizHistorico.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizHistoricoDto.DataExibido), "Data Exibido"),
                new AntdUI.Column(nameof(QuizHistoricoDto.DataInicio), "Data Iniciado"),
                new AntdUI.Column(nameof(QuizHistoricoDto.FoiConcluido), "Concluído"),
                new AntdUI.Column(nameof(QuizHistoricoDto.DataConcluido), "Data Concluído"),
                new AntdUI.Column(nameof(QuizHistoricoDto.TempoDeConclusao), "Tempo para concluir"),
                new AntdUI.Column(nameof(QuizHistoricoDto.TotalQuestoes), "Total Questões"),
                new AntdUI.Column(nameof(QuizHistoricoDto.TotalAcertos), "Acertos"),
                new AntdUI.Column(nameof(QuizHistoricoDto.PontuacaoTotal), "Pontuação Final"),
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

                foreach (QuizHistoricoDto quiz in _quizzes)
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
