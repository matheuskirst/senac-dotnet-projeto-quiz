using SenacQuizApp.Services;
using SenacQuizApp.Dtos;

namespace SenacQuizApp.Telas.QuizDiario
{
    public partial class HubQuizDiario : UserControl
    {
        private readonly QuizDiarioService _quizDiarioService;
        private readonly UsuarioService _usuarioPerfilService;
        private QuizDiarioAndamentos? _quizDiarioDto;

        public event Action<int>? IniciarQuiz;
        public event Action<int>? VerResultado;
        public event Action<int>? CarregarQuiz;

        public HubQuizDiario(QuizDiarioService quizDiarioService, UsuarioService usuarioPerfilService)
        {
            _quizDiarioService = quizDiarioService;
            _usuarioPerfilService = usuarioPerfilService;

            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {
            try
            {
                QuizDiarioAndamentos? quiz = await _quizDiarioService.ObterQuizDiario();

                if (quiz == null)
                {
                    LabelStatus.Text = "Disponível";
                    ButtonQuizDiario.Text = "Iniciar";
                    ButtonQuizDiario.Click += IniciarQuiz_Click;
                }

                if (quiz != null && quiz.FoiConcluido)
                {
                    _quizDiarioDto = quiz;
                    LabelStatus.Text = "Concluido";
                    ButtonQuizDiario.Text = "Resultado";
                    ButtonQuizDiario.Click += VerResultadosQuiz_Click;
                }

                if (quiz != null && quiz.FoiConcluido == false)
                {
                    _quizDiarioDto = quiz;
                    LabelStatus.Text = "Não finalizado";
                    ButtonQuizDiario.Text = "Continuar";
                    ButtonQuizDiario.Click += ContinuarQuiz_Click;
                }
            }
            catch
            {

            }
        }

        private async void IniciarQuizDiario()
        {
            try
            {
                QuizDiarioAndamentos? quiz = await _quizDiarioService.CriarQuizDiario();

                if (quiz == null) return;

                IniciarQuiz?.Invoke(quiz.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocorreu um erro ao criar o quiz diário {ex.ToString()}.",
                    "Erro de Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void VerResultadoDiario()
        {
            if (_quizDiarioDto == null) return;
            VerResultado?.Invoke(_quizDiarioDto.Id);
        }

        private void ContinuarQuizDiario()
        {
            if (_quizDiarioDto == null) return;
            CarregarQuiz?.Invoke(_quizDiarioDto.Id);
        }

        private void IniciarQuiz_Click(object? sender, EventArgs e)
        {
            IniciarQuizDiario();
        }

        private void VerResultadosQuiz_Click(object? sender, EventArgs e)
        {
            VerResultadoDiario();
        }

        private void ContinuarQuiz_Click(object? sender, EventArgs e)
        {
            ContinuarQuizDiario();
        }
    }
}
