using SenacQuizApp.Services;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Telas
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly UsuarioService _usuarioService;
        private readonly PerguntaService _perguntaService;
        public PaginaQuiz(UsuarioService usuarioService, PerguntaService perguntaService)
        {
            _usuarioService = usuarioService;
            _perguntaService = perguntaService;

            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {
            Quiz quiz = await _perguntaService.CriarQuiz();

            Pergunta pergunta = quiz.Perguntas.First();
        }
    }
}
