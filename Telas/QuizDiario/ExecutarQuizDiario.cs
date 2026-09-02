using SenacQuizApp.Services;
using SenacQuizApp.Global;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Dtos;

namespace SenacQuizApp.Telas.QuizDiario
{
    public partial class ExecutarQuizDiario : UserControl
    {
        private int _quizId;
        private readonly QuizService _quizService;
        private readonly UsuarioService _usuarioService;

        public event Action<int>? VerResultado;


        private PainelQuestaoDiario _painelQuestao;
        private QuizSessao? _quizSessao;

        public ExecutarQuizDiario(int quizId, QuizService quizService, UsuarioService usuarioService)
        {
            _quizId = quizId;
            _quizService = quizService;
            _usuarioService = usuarioService;

            _painelQuestao = new PainelQuestaoDiario()
            {
                Dock = DockStyle.Fill
            };
            _painelQuestao.EscolheuAlternativa += AoResponderAlternativa;
            _painelQuestao.EscolheuVerdadeiroFalso += AoResponderVerdadeiroFalso;

            InitializeComponent();
        }

        private async void ExecutarQuizDiario_Load(object sender, EventArgs e)
        {
            try
            {
                PanelQuestoes.Controls.Add(_painelQuestao);

                QuizDiarioAndamentos? quiz = await _quizService.ObterDetalhePorId(_quizId);
                UsuarioPerfilDto? usuario = await _usuarioService.ObterPerfilPorId(UsuarioAtual.Id);

                if (quiz == null) return;

                if (quiz.FoiConcluido) { MostrarResultado(); }

                if (usuario != null)
                {
                    LabelUsuarioNick.Text = usuario.Nickname;
                    LabelUsuarioNivel.Text = usuario.Nivel;
                }

                LabelQuizDiarioData.Text = quiz.DataExibido.ToString();

                _quizSessao = new QuizSessao
                {
                    Quiz = quiz,
                    QuestaoAtualIndex = 0,
                    SequenciaAcertos = 0
                };

                await ProximaQuestao();
            }
            catch
            {

            }
        }

        private async Task ProximaQuestao()
        {
            if (_quizSessao == null) return;

            int questaoIndex = _quizSessao.QuestaoAtualIndex;

            if (questaoIndex >= _quizSessao.Quiz.Questoes.Count)
            {
                await FinalizarQuiz();
                return;
            }
            
            QuestaoAndamento questao = _quizSessao.Quiz.Questoes[questaoIndex];

            if (questao.Respondida)
            {
                if (questao.Acertou == true) _quizSessao.SequenciaAcertos++;
                else _quizSessao.SequenciaAcertos = 0;

                _quizSessao.QuestaoAtualIndex++;
                await ProximaQuestao();
                return;
            }
            else
            {
                int bonus = 0;
                int valorFinal = questao.Pontos;

                if (_quizSessao.SequenciaAcertos >= 5) bonus = 20;
                else if (_quizSessao.SequenciaAcertos >= 3) bonus = 10;
                else bonus = 0;

                valorFinal += (valorFinal * bonus) / 100;

                LabelQuizSequenciaAcertos.Text = $"{_quizSessao.SequenciaAcertos}";

                LabelQuizQuestaoAtual.Text = $"{questaoIndex + 1}";
                LabelQuizQuestaoBonus.Text = $"{bonus}%";
                LabelQuizQuestaoPontos.Text = $"{valorFinal} Pontos";

                _painelQuestao.CarregarQuestao(questao);
            }
        }

        private async void AoResponderAlternativa(int alternativaId)
        {
            if (_quizSessao == null) return;
            int quizId = _quizSessao.Quiz.Id;
            int questaoIndex = _quizSessao.QuestaoAtualIndex;
            int questaoId = _quizSessao.Quiz.Questoes[questaoIndex].Id;
            int sequenciaAcertos = _quizSessao.SequenciaAcertos;

            bool? ehCorreta = await _quizService.SalvarRespostaAlternativa(quizId, questaoId, alternativaId, sequenciaAcertos);

            if (ehCorreta != null && ehCorreta.Value) _quizSessao.SequenciaAcertos++;
            else _quizSessao.SequenciaAcertos = 0;

            _quizSessao.QuestaoAtualIndex++;

            await ProximaQuestao();
        }

        private async void AoResponderVerdadeiroFalso(bool verdadeiroFalso)
        {
            if (_quizSessao == null) return;
            int quizId = _quizSessao.Quiz.Id;
            int questaoIndex = _quizSessao.QuestaoAtualIndex;
            int questaoId = _quizSessao.Quiz.Questoes[questaoIndex].Id;
            int sequenciaAcertos = _quizSessao.SequenciaAcertos;


            bool? ehCorreta = await _quizService.SalvarRespostaVerdadeiroFalso(quizId, questaoId, verdadeiroFalso, sequenciaAcertos);

            if (ehCorreta != null && ehCorreta.Value) _quizSessao.SequenciaAcertos++;
            else _quizSessao.SequenciaAcertos = 0;

            _quizSessao.QuestaoAtualIndex++;

            await ProximaQuestao();
        }

        private async Task FinalizarQuiz()
        {
            if (_quizSessao == null) return;

            await _quizService.ConcluirQuiz(_quizSessao.Quiz.Id);
            MostrarResultado();
        }

        private void MostrarResultado()
        {
            if (_quizSessao == null) return;

            VerResultado?.Invoke(_quizSessao.Quiz.Id);
            _quizSessao = null;
        }
    }

    public class QuizSessao
    {
        public QuizDiarioAndamentos Quiz { get; set; } = null!;
        public int QuestaoAtualIndex { get; set; }
        public int SequenciaAcertos { get; set; }
    }
}
