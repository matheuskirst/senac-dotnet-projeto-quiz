using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes.Quiz;
using SenacQuizApp.Dtos.QuizDiario.Detalhe;
using SenacQuizApp.Dtos.QuizDiario.Historico;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly QuizDiarioService _quizService;

        public event EventHandler? RealizarLogout;
        public event EventHandler? AbrirHubQuizDiario;
        public event EventHandler? AbrirHubQuizRush;

        public PaginaPrincipal(QuizDiarioService quizService)
        {
            _quizService = quizService;

            InitializeComponent();
        }

        private async void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonQuizDiario_Click(object sender, EventArgs e)
        {
            AbrirHubQuizDiario?.Invoke(this, EventArgs.Empty);
        }
    }
}
