using SenacQuizApp.Dtos.QuizDiario.Detalhe;
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas.Quiz_Diario
{
    public partial class ExecutarQuizDiario : UserControl
    {
        private int _quizId;
        private readonly QuizDiarioService _quizService;
        private readonly UsuarioPerfilService _usuarioPerfilService;

        public event Action<int>? VerResultado;

        private QuizSessao? _quizSessao;

        public ExecutarQuizDiario(int quizId, QuizDiarioService quizService, UsuarioPerfilService usuarioPerfilService)
        {
            _quizId = quizId;
            _quizService = quizService;
            _usuarioPerfilService = usuarioPerfilService;

            InitializeComponent();
        }

        private async void ExecutarQuizDiario_Load(object sender, EventArgs e)
        {
            try
            {
                QuizDiarioDetalhes? quiz = await _quizService.ObterDetalhePorId(_quizId);

                if (quiz == null) return;

                LabelQuizDiarioData.Text = quiz.DataExibido.ToString();

                _quizSessao = new QuizSessao
                {
                    Quiz = quiz,
                    QuestaoAtualIndex = 0,
                    SequenciaAcertos = 0
                };

                ProximaPergunta();
            }
            catch
            {

            }
        }
        
        private void ProximaPergunta()
        {

        }
    }
    public class QuizSessao
    {
        public QuizDiarioDetalhes Quiz { get; set; } = null!;
        public int QuestaoAtualIndex { get; set; }
        public int SequenciaAcertos { get; set; }
    }
}
