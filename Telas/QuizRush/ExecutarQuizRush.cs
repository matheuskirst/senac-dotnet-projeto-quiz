using AntdUI;
using Microsoft.EntityFrameworkCore.Design;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using System.Diagnostics;

namespace SenacQuizApp.Telas.QuizRush
{
    public partial class ExecutarQuizRush : UserControl
    {
        private readonly UsuarioService _usuarioService;
        private readonly QuizRushService _quizRushService;
        private readonly QuestaoService _questaoService;

        public event EventHandler? VerResultado;

        private PainelQuestaoRush _painelQuestao;
        private RushSessao? _rushSessao;

        private TimeSpan _tempoDefinido = TimeSpan.FromSeconds(15);
        private Stopwatch _cronometro = new Stopwatch();
        private System.Windows.Forms.Timer _timerAtualizarLabel = new();

        public ExecutarQuizRush(UsuarioService usuarioService, QuizRushService quizRushService, QuestaoService questaoService)
        {
            _usuarioService = usuarioService;
            _quizRushService = quizRushService;
            _questaoService = questaoService;

            _painelQuestao = new PainelQuestaoRush
            {
                Dock = DockStyle.Fill
            };
            _painelQuestao.EscolheuAlternativa += AoResponderAlternativa;
            _painelQuestao.EscolheuVerdadeiroFalso += AoResponderVerdadeiroFalso;

            InitializeComponent();

            _timerAtualizarLabel.Interval = 16;

            _timerAtualizarLabel.Tick += AoAcabarTempo;
        }

        private async void ExecutarQuizRush_Load(object sender, EventArgs e)
        {
            try
            {
                PanelQuestoes.Controls.Add(_painelQuestao);

                UsuarioPerfil? usuario = await _usuarioService.ObterPerfilPorId(UsuarioAtual.Id);

                if (usuario != null)
                {
                    LabelUsuarioNick.Text = usuario.Nickname;
                    LabelUsuarioNivel.Text = usuario.Nivel;
                }

                _rushSessao = new RushSessao
                {
                    QuestaoAtual = null,
                    QuestaoAtualIndex = 0,
                    Streak = 0
                };

                await ProximaQuestao();
            }
            catch
            {

            }
        }

        private async Task ProximaQuestao()
        {
            if (_rushSessao == null) return;
            _rushSessao.QuestaoAtual = null;


            QuestaoExibicao? questao = await _questaoService.ObterAleatorio();

            if (questao == null) return;
            
            _cronometro.Restart();
            _timerAtualizarLabel.Start();

            _rushSessao.QuestaoAtual = questao;

            LabelDificuldade.Text = $"{_rushSessao.QuestaoAtual.Nivel}";

            _painelQuestao.CarregarQuestao(questao);
        }

        private async void AoAcabarTempo(object? sender, EventArgs e)
        {
            TimeSpan decorrido = _cronometro.Elapsed;

            TimeSpan restante = _tempoDefinido - decorrido;


            if (restante <= TimeSpan.Zero)
            {
                _timerAtualizarLabel.Stop();

                await Encerrar();
                return;
            }


            LabelTempo.Text = restante.ToString(@"s\s\:ff\m\s");
        }

        private async Task Encerrar()
        {
            _timerAtualizarLabel.Stop();
            _cronometro.Stop();
            if (_rushSessao == null || _timerAtualizarLabel == null) return;
            var dataIniciado = _rushSessao.DataIniciado;
            var streak = _rushSessao.Streak;
            var pontos = _rushSessao.Pontos;

            bool quizId = await _quizRushService.FinalizarPartidaRush(dataIniciado, streak, pontos);


            VerResultado?.Invoke(this, EventArgs.Empty);
        }

        private async void AoResponderAlternativa(int alternativaId)
        {
            if (_rushSessao == null || _rushSessao.QuestaoAtual == null) return;
            var questao = _rushSessao.QuestaoAtual;
            int streak = _rushSessao.Streak;

            bool? ehCorreta = await _quizRushService.VerificarRespostaAlternativa(alternativaId);

            if (ehCorreta != null && ehCorreta.Value)
            {
                _rushSessao.Streak++;
                _rushSessao.Pontos += questao.Pontos;
                LabelStreak.Text = _rushSessao.Streak.ToString();
                LabelPontuacaoTotal.Text = _rushSessao.Pontos.ToString();
                await ProximaQuestao();
            }
            else await Encerrar();
        }

        private async void AoResponderVerdadeiroFalso(bool verdadeiroFalso)
        {
            if (_rushSessao == null || _rushSessao.QuestaoAtual == null) return;
            var questao = _rushSessao.QuestaoAtual;

            bool? ehCorreta = await _quizRushService.VerificarRespostaVerdadeiroFalso(questao.Id, verdadeiroFalso);

            if (ehCorreta != null && ehCorreta.Value)
            {
                _rushSessao.Streak++;
                _rushSessao.Pontos += questao.Pontos;
                LabelStreak.Text = _rushSessao.Streak.ToString();
                LabelPontuacaoTotal.Text = _rushSessao.Pontos.ToString();
                await ProximaQuestao();
            }
            else await Encerrar();
        }
    }

    public class RushSessao
    {
        public QuestaoExibicao? QuestaoAtual { get; set; }
        public int QuestaoAtualIndex { get; set; }
        public DateTimeOffset DataIniciado { get; set; } = DateTimeOffset.Now;
        public int Streak { get; set; }
        public int Pontos { get; set; }
    }
}
