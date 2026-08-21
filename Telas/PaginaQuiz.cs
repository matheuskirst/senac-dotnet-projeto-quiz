using SenacQuizApp.Services;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Telas
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly QuizExecucaoService _quizExecucaoService;
        public PaginaQuiz(QuizExecucaoService quizExecucaoService)
        {
            _quizExecucaoService = quizExecucaoService;

            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {
            ObterQuizResponse quizResposta = await _quizExecucaoService.ObterQuizDiario();

            if (quizResposta.IsSucesso)
            {
                QuizDto? quiz = quizResposta.Data;

                if (quiz == null) return;

                PerguntaDto pergunta = quiz.Perguntas.First();

                InputPergunta.Text = pergunta.Enunciado;

                foreach(AlternativaDto alternativa in pergunta.Alternativas)
                {
                    AntdUI.Button button = new AntdUI.Button();
                    button.Text = alternativa.Texto;

                    button.Dock = DockStyle.Fill;
                    PanelAlternativas.Controls.Add(button);
                }
            }
        }
    }
}
