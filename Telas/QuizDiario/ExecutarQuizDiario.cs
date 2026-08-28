using SenacQuizApp.Dtos.QuizDiario.Andamento;
using SenacQuizApp.Migrations;
using SenacQuizApp.Modelos.Usuarios;
using SenacQuizApp.Services;
using SenacQuizApp.Telas;
using SenacQuizApp.Global;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Telas.QuizDiario
{
    public partial class ExecutarQuizDiario : UserControl
    {
        private int _quizId;
        private readonly QuizDiarioService _quizService;
        private readonly UsuarioService _usuarioService;

        public event Action<int>? VerResultado;

        private QuizSessao? _quizSessao;

        public ExecutarQuizDiario(int quizId, QuizDiarioService quizService, UsuarioService usuarioService)
        {
            _quizId = quizId;
            _quizService = quizService;
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private async void ExecutarQuizDiario_Load(object sender, EventArgs e)
        {
            try
            {
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

                ProximaQuestao();
            }
            catch
            {

            }
        }

        private void MudarPainelQuestao(PainelQuestaoDiario painel)
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
            if (_quizSessao == null) return;

            int questaoIndex = _quizSessao.QuestaoAtualIndex;

            if (questaoIndex >= _quizSessao.Quiz.Questoes.Count)
            {
                await FinalizarQuiz();
                return;
            }
            
            QuizDiarioAndamentoQuestao questao = _quizSessao.Quiz.Questoes[questaoIndex];

            if (questao.Respondida)
            {
                if (questao.Acertou == true) _quizSessao.SequenciaAcertos++;
                else _quizSessao.SequenciaAcertos = 0;

                _quizSessao.QuestaoAtualIndex++;
                ProximaQuestao();
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

                var painel = new PainelQuestaoDiario(questao);
                painel.EscolheuAlternativa += AoResponderAlternativa;
                painel.EscolheuVerdadeiroFalso += AoResponderVerdadeiroFalso;

                painel.Dock = DockStyle.Fill;

                MudarPainelQuestao(painel);
            }
        }

        private async void AoResponderAlternativa(int alternativaId)
        {
            if (_quizSessao == null) return;
            int quizId = _quizSessao.Quiz.Id;
            int questaoIndex = _quizSessao.QuestaoAtualIndex;
            int questaoId = _quizSessao.Quiz.Questoes[questaoIndex].Id;
            int sequenciaAcertos = _quizSessao.SequenciaAcertos;

            bool ehCorreta = await _quizService.SalvarRespostaAlternativa(quizId, questaoId, alternativaId, sequenciaAcertos);

            if (ehCorreta) _quizSessao.SequenciaAcertos++;
            else _quizSessao.SequenciaAcertos = 0;

            _quizSessao.QuestaoAtualIndex++;

            ProximaQuestao();
        }

        private async void AoResponderVerdadeiroFalso(bool verdadeiroFalso)
        {
            if (_quizSessao == null) return;
            int quizId = _quizSessao.Quiz.Id;
            int questaoIndex = _quizSessao.QuestaoAtualIndex;
            int questaoId = _quizSessao.Quiz.Questoes[questaoIndex].Id;
            int sequenciaAcertos = _quizSessao.SequenciaAcertos;


            bool ehCorreta = await _quizService.SalvarRespostaVerdadeiroFalso(quizId, questaoId, verdadeiroFalso, sequenciaAcertos);

            if (ehCorreta) _quizSessao.SequenciaAcertos++;
            else _quizSessao.SequenciaAcertos = 0;

            _quizSessao.QuestaoAtualIndex++;

            ProximaQuestao();
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
