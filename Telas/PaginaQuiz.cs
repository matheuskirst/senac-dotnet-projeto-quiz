using SenacQuizApp.Services;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Telas
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly AutenticacaoService _usuarioService;
        private readonly QuizExecucaoService _quizService;
        private QuizDto? QuizAtual;
        public PaginaQuiz(AutenticacaoService usuarioService, QuizExecucaoService quizService)
        {
            _usuarioService = usuarioService;
            _quizService = quizService;

            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
