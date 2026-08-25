using SenacQuizApp.Services;
using SenacQuizApp.Dtos.Quiz;
using SenacQuizApp.Dtos.Quiz.Concluido;
using SenacQuizApp.Telas.Componentes.Quiz;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly int _quizId;
        private readonly QuizService _quizService;
        private readonly UsuarioPerfilService _usuarioPerfilService;
        private QuizSessao? _quizSessao;

        public event EventHandler? VoltarParaOMenu;
        public PaginaQuiz(int quizId, QuizService quizService, UsuarioPerfilService usuarioPerfilService)
        {
            _quizId = quizId;
            _quizService = quizService;
            _usuarioPerfilService = usuarioPerfilService;

            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {
            try
            {
                QuizDto? quiz = await _quizService.ObterQuiz(_quizId);

                if (quiz != null)
                {
                    PanelQuizProgresso.Visible = true;
                    if (quiz.FoiConcluido)
                    {
                        await MostrarQuizFinalizado(quiz.Id);
                    }
                    else
                    {
                        _quizSessao = new QuizSessao
                        { 
                            Quiz = quiz,
                            QuestaoAtualIndex = 0,
                            SequenciaAcertos = 0
                        };
                        ProximaQuestao();
                    }
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

                VoltarParaOMenu?.Invoke(this, EventArgs.Empty);
            }
        }

        private void MudarPainel(UserControl painel)
        {
            while (PanelQuestoes.Controls.Count > 0)
            {
                var controle = PanelQuestoes.Controls[0];
                PanelQuestoes.Controls.Remove(controle);
                controle.Dispose();
            }
            PanelQuestoes.Controls.Add(painel);
        }

        private async void ProximaQuestao()
        {
            if (_quizSessao != null)
            {
                int index = _quizSessao.QuestaoAtualIndex;
                LabelQuizQuestaoIndex.Text = $"{index + 1}";

                var questao = _quizSessao.Quiz.Questoes[index];
                var painelQuestao = new PainelQuestoes(questao);

                if (questao.Respondida)
                {
                    if (questao.Acertou == true)
                    {
                        _quizSessao.SequenciaAcertos++;
                    }
                    else if (questao.Acertou == false)
                    {
                        _quizSessao.SequenciaAcertos = 0;
                    }

                    _quizSessao.QuestaoAtualIndex++;
                    ProximaQuestao();
                }
                else
                {
                    painelQuestao.Dock = DockStyle.Fill;
                    painelQuestao.EscolheuAlternativa += AoResponder;
                    painelQuestao.EscolheuVerdadeiro += AoResponder;

                    MudarPainel(painelQuestao);
                }
                LabelQuizSequenciaAcertos.Text = _quizSessao.SequenciaAcertos.ToString();
            }
        }

        private async void AoResponder(int alternativaId)
        {
            if (_quizSessao != null)
            {
                int quizId = _quizSessao.Quiz.Id;
                int index = _quizSessao.QuestaoAtualIndex;
                var questao = _quizSessao.Quiz.Questoes[index];
                int sequenciaAcertos = _quizSessao.SequenciaAcertos;

                bool correta = await _quizService.SalvarResposta(quizId, questao, sequenciaAcertos, alternativaId: alternativaId);

                if (correta)
                {
                    _quizSessao.SequenciaAcertos++;
                }
                else
                {
                    _quizSessao.SequenciaAcertos = 0;
                }

                if (index < _quizSessao.Quiz.Questoes.Count - 1)
                {
                    _quizSessao.QuestaoAtualIndex++;
                    ProximaQuestao();
                }
                else
                {
                    await FinalizarQuiz();
                }
            }
        }
        
        private async void AoResponder(bool verdadeira)
        {
            if (_quizSessao != null)
            {
                int quizId = _quizSessao.Quiz.Id;
                int index = _quizSessao.QuestaoAtualIndex;
                var questao = _quizSessao.Quiz.Questoes[index];
                int sequenciaAcertos = _quizSessao.SequenciaAcertos;

                bool correta = await _quizService.SalvarResposta(quizId, questao, sequenciaAcertos, verdadeiro: verdadeira);

                if (correta)
                {
                    _quizSessao.SequenciaAcertos++;
                }
                else
                {
                    _quizSessao.SequenciaAcertos = 0;
                }

                if (index < _quizSessao.Quiz.Questoes.Count - 1)
                {
                    _quizSessao.QuestaoAtualIndex++;
                    ProximaQuestao();
                }
                else
                {
                    await FinalizarQuiz();
                }
            }
        }

        private async Task FinalizarQuiz()
        {
            if (_quizSessao != null)
            {
                await _quizService.ConcluirQuiz(_quizSessao.Quiz.Id);
                MessageBox.Show(
                    "O quiz foi concluido.",
                    "Quiz concluido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                await MostrarQuizFinalizado(_quizSessao.Quiz.Id);
            }
        }

        private async Task MostrarQuizFinalizado(int quizId)
        {
            PanelQuizProgresso.Visible = false;
            QuizConcluidoDto? quizConcluido = await _quizService.ObterQuizConcluido(quizId);

            if (quizConcluido != null)
            {
                var painelResultado = new PainelResultado(quizConcluido);
                painelResultado.Dock = DockStyle.Fill;

                MudarPainel(painelResultado);
            }
        }
    }

    public class QuizSessao
    {
        public QuizDto Quiz { get; set; } = null!;
        public int QuestaoAtualIndex { get; set; }
        public int SequenciaAcertos { get; set; }
    }
}
