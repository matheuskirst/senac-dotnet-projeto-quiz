using SenacQuizApp.Services;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly UsuarioService _usuarioService;
        private readonly PerguntaService _perguntaService;
        private List<PainelQuizPergunta>? PaineisPerguntas;
        private int PerguntaAtualIndex;
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

            PainelQuizPergunta painel = new PainelQuizPergunta(pergunta);

            painel.Dock = DockStyle.Fill;

            panelPergunta.Controls.Add(painel);
        }
    }
}
