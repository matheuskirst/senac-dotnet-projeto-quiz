using SenacQuizApp.Services;
using SenacQuizApp.Dtos.Quiz;
using SenacQuizApp.Dtos.Quiz.Historico;
using SenacQuizApp.Telas.Componentes.Quiz;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly QuizService _quizService;
        private QuizDto? _quizDiario;

        public event EventHandler? RealizarLogout;
        public event Action<int>? AbrirQuizDiario;
        public PaginaPrincipal(QuizService quizService)
        {
            _quizService = quizService;

            InitializeComponent();
        }

        private async void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                QuizDto? quizDiario = await _quizService.ObterQuizDiario();
                if (quizDiario != null)
                {
                    _quizDiario = quizDiario;
                    QuizDiarioStatus();
                }
            }
            catch
            {
                MessageBox.Show(
                    "Ocorreu um erro ao se conectar com o servidor.",
                    "Erro de Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            await CarregarHistoricoPreview();
        }

        private async Task CarregarHistoricoPreview()
        {
            List<QuizHistoricoDto> quizzes = await _quizService.ObterHistorico();
            var painelHistorico = new PainelHistoricoQuiz(quizzes);
            painelHistorico.Dock = DockStyle.Fill;
            PanelHistoricoPreview.Controls.Add(painelHistorico);
            painelHistorico.BringToFront();
        }

        private void QuizDiarioStatus()
        {
            if (_quizDiario == null)
                LabelQuizDiarioStatus.Text = "Erro";
            else
                LabelQuizDiarioStatus.Text = _quizDiario.FoiConcluido ? "Concluído" : "Disponível";
        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonQuizDiario_Click(object sender, EventArgs e)
        {
            if (_quizDiario != null)
                AbrirQuizDiario?.Invoke(_quizDiario.Id);
        }
    }
}
