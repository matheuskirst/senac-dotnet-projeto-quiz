using AntdUI;
using SenacQuizApp.Dtos.Conquista;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.QuizDiario;
using SenacQuizApp.Telas.QuizRush;

namespace SenacQuizApp.Telas
{
    public partial class FormApp : Window
    {
        private readonly AutenticacaoService _autenticacaoService;
        private readonly QuizDiarioService _quizDiarioService;
        private readonly QuizRushService _quizRushService;
        private readonly UsuarioService _usuarioPerfilService;
        private readonly RankingService _rankingService;
        private readonly HistoricoService _historicoService;
        private readonly ConquistaService _conquistaService;
        private readonly QuestaoService _questaoService;

        private PaginaAtual? _paginaAtual;

        public FormApp(
            AutenticacaoService autenticacaoService,
            QuizDiarioService quizDiarioService,
            QuizRushService quizRushService,
            UsuarioService usuarioPerfilService,
            RankingService rankingService,
            HistoricoService historicoService,
            ConquistaService conquistaService,
            QuestaoService questaoService
            )
        {
            _autenticacaoService = autenticacaoService;
            _quizDiarioService = quizDiarioService;
            _quizRushService = quizRushService;
            _usuarioPerfilService = usuarioPerfilService;
            _rankingService = rankingService;
            _historicoService = historicoService;
            _conquistaService = conquistaService;
            _questaoService = questaoService;

            _conquistaService.ConquistaDesbloqueada += AoDesbloquearConquista;
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            var dropdownItems = new object[]
            {
                new AntdUI.SelectItem("Ver Perfil") { Tag = MenuOpcoes.VerPerfil },
                new AntdUI.SelectItem("Ver Histórico") { Tag = MenuOpcoes.VerHistorico },
                new AntdUI.SelectItem("Configurações") { Tag = MenuOpcoes.Configuracoes },
                new AntdUI.SelectItem("Sair...") { Tag = MenuOpcoes.Sair }
            };

            DropdownUsuarioMenu.Items.AddRange(dropdownItems);

            AlternarBotaoHeader(ButtonHeaderMenu);
            AbrirPaginaInicial(null, e);
        }

        public void MudarPagina(UserControl pagina)
        {
            PanelAppBody.SuspendLayout();

            if (pagina is PaginaInicial
                || pagina is PaginaLogin
                || pagina is PaginaSignup
            )
            {
                DropdownUsuarioMenu.Visible = false;
                DropdownUsuarioMenu.Enabled = false;
                PanelAppHeader.Visible = false;
            }
            else
            {
                DropdownUsuarioMenu.Visible = true;
                DropdownUsuarioMenu.Enabled = true;
                PanelAppHeader.Visible = true;
            }

            this.ActiveControl = null;

            while (PanelAppBody.Controls.Count > 0)
            {
                var controle = PanelAppBody.Controls[0];
                PanelAppBody.Controls.Remove(controle);
                controle.Dispose();
            }

            pagina.Dock = DockStyle.Fill;
            PanelAppBody.Controls.Add(pagina);
            PanelAppBody.ResumeLayout();
        }

        public void AbrirPaginaInicial(object? sender, EventArgs e)
        {
            _autenticacaoService.RealizarLogout();
            var paginaInicial = new PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);

            _paginaAtual = new PaginaAtual { Pagina = paginaInicial, Propriedade = null };
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            var paginaLogin = new PaginaLogin(_autenticacaoService);

            paginaLogin.EscolheuVoltar += AbrirPaginaInicial;
            paginaLogin.ConcluiuLogin += AoConcluirLogin;

            MudarPagina(paginaLogin);

            _paginaAtual = new PaginaAtual { Pagina = paginaLogin, Propriedade = null };
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            var paginaSignup = new PaginaSignup(_autenticacaoService);

            paginaSignup.EscolheuVoltar += AbrirPaginaInicial;
            paginaSignup.ConcluiuSignup += AoConcluirLogin;

            MudarPagina(paginaSignup);

            _paginaAtual = new PaginaAtual { Pagina = paginaSignup, Propriedade = null };
        }
        private void AoConcluirLogin(object? sender, EventArgs e)
        {
            AbrirPaginaPrincipal(sender, EventArgs.Empty);
            DropdownUsuarioMenu.Text = UsuarioAtual.Username;
        }

        public void AbrirPaginaPrincipal(object? sender, EventArgs e)
        {
            var paginaPrincipal = new PaginaPrincipal(_historicoService);

            AlternarBotaoHeader(ButtonHeaderMenu);

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.AbrirHubQuizDiario += AbrirHubQuizDiario;
            paginaPrincipal.AbrirHubQuizRush += AbrirIniciarQuizRush;

            paginaPrincipal.ContinuarQuizDiario += AbrirExecutarQuizDiario;
            paginaPrincipal.VerResultado += AoEscolherResultadoQuiz;

            MudarPagina(paginaPrincipal);

            _paginaAtual = new PaginaAtual { Pagina = paginaPrincipal, Propriedade = null };
        }

        public void AbrirPaginaRanking(object? sender, EventArgs e)
        {
            var paginaRanking = new PaginaRanking(_rankingService);

            AlternarBotaoHeader(ButtonHeaderRanking);

            paginaRanking.AbrirPerfil += AbrirPaginaPerfil;

            MudarPagina(paginaRanking);

            _paginaAtual = new PaginaAtual { Pagina = paginaRanking, Propriedade = null };
        }

        public void AbrirPaginaConquistas()
        {
            var paginaConquistas = new PaginaConquistas(_conquistaService);

            AlternarBotaoHeader(ButtonHeaderConquista);

            MudarPagina(paginaConquistas);

            _paginaAtual = new PaginaAtual { Pagina = paginaConquistas, Propriedade = null };
        }

        public void AbrirPaginaPerfil(object? sender, int usuarioId)
        {
            var paginaPerfil = new PaginaPerfil(usuarioId, _usuarioPerfilService);

            AlternarBotaoHeader(ButtonHeaderConquista);

            MudarPagina(paginaPerfil);

            _paginaAtual = new PaginaAtual { Pagina = paginaPerfil, Propriedade = usuarioId };
        }

        public void AbrirPaginaHistorico()
        {
            var paginaHistorico = new PaginaHistorico(_historicoService);

            AlternarBotaoHeader();

            paginaHistorico.ContinuarQuiz += AbrirExecutarQuizDiario;
            paginaHistorico.VerResultado += AoEscolherResultadoQuiz;

            MudarPagina(paginaHistorico);

            _paginaAtual = new PaginaAtual { Pagina = paginaHistorico, Propriedade = null };
        }

        public void AoEscolherResultadoQuiz(int quizId, QuizTipo tipo)
        {
            switch (tipo)
            {
                case QuizTipo.Diario:
                    AbrirResultadoQuizDiario(quizId);
                    break;
                case QuizTipo.Rush:
                    AbrirResultadoQuizRush(quizId);
                    break;
            }
        }

        public void AbrirConfiguracoes()
        {
            var formConfig = new PaginaConfig();

            formConfig.ShowDialog();

            AlternarBotaoHeader();
        }

        // ============================================================
        // Quiz Diário
        // ============================================================

        public void AbrirHubQuizDiario(object? sender, EventArgs e)
        {
            AlternarBotaoHeader();

            var hubQuizDiario = new HubQuizDiario(_quizDiarioService, _usuarioPerfilService);

            hubQuizDiario.IniciarQuiz += AbrirExecutarQuizDiario;
            hubQuizDiario.VerResultado += AbrirResultadoQuizDiario;
            hubQuizDiario.CarregarQuiz += AbrirExecutarQuizDiario;

            MudarPagina(hubQuizDiario);

            _paginaAtual = new PaginaAtual { Pagina = hubQuizDiario, Propriedade = null };
        }

        public void AbrirExecutarQuizDiario(int quizId)
        {
            AlternarBotaoHeader();

            var executarQuizDiario = new ExecutarQuizDiario(quizId, _quizDiarioService, _usuarioPerfilService);

            executarQuizDiario.VerResultado += AbrirResultadoQuizDiario;

            MudarPagina(executarQuizDiario);

            _paginaAtual = new PaginaAtual { Pagina = executarQuizDiario, Propriedade = quizId };
        }

        public void AbrirResultadoQuizDiario(int quizId)
        {
            AlternarBotaoHeader();

            var resultadoQuizDiario = new ResultadoQuizDiario(quizId, _quizDiarioService);

            MudarPagina(resultadoQuizDiario);

            _paginaAtual = new PaginaAtual { Pagina = resultadoQuizDiario, Propriedade = quizId };
        }

        // ============================================================
        // Quiz Rush
        // ============================================================

        public void AbrirIniciarQuizRush(object? sender, EventArgs e)
        {
            AlternarBotaoHeader();

            var hub = new IniciarQuizRush();

            hub.IniciarRush += AbrirExecutarQuizRush;

            MudarPagina(hub);

            _paginaAtual = new PaginaAtual { Pagina = hub, Propriedade = null };
        }

        public void AbrirExecutarQuizRush(object? sender, EventArgs e)
        {
            AlternarBotaoHeader();

            var executarQuizDiario = new ExecutarQuizRush(_usuarioPerfilService, _quizRushService, _questaoService);

            executarQuizDiario.VerResultado += AbrirResultadoQuizRush;

            MudarPagina(executarQuizDiario);

            _paginaAtual = new PaginaAtual { Pagina = executarQuizDiario, Propriedade = null };
        }

        public void AbrirResultadoQuizRush(int quizId)
        {
            AlternarBotaoHeader();

            var resultadoQuizDiario = new ResultadoQuizRush(quizId, _quizRushService);

            MudarPagina(resultadoQuizDiario);

            _paginaAtual = new PaginaAtual { Pagina = resultadoQuizDiario, Propriedade = quizId };
        }

        // ============================================================
        // Botões Header
        // ============================================================

        private void AlternarBotaoHeader(object? sender = null)
        {
            ButtonHeaderMenu.Toggle = false;
            ButtonHeaderMenu.DefaultBorderColor = Color.FromArgb(40, 40, 40);

            ButtonHeaderRanking.Toggle = false;
            ButtonHeaderRanking.DefaultBorderColor = Color.FromArgb(40, 40, 40);

            ButtonHeaderConquista.Toggle = false;
            ButtonHeaderConquista.DefaultBorderColor = Color.FromArgb(40, 40, 40);

            if (sender is AntdUI.Button button)
            {
                button.DefaultBorderColor = Color.FromArgb(66, 160, 245);
                button.Toggle = true;
            }
        }

        private void ButtonHeaderMenu_Click(object sender, EventArgs e)
        {
            if (_paginaAtual?.Pagina is not PaginaPrincipal)
            {
                AbrirPaginaPrincipal(sender, EventArgs.Empty);
            }
        }

        private void ButtonHeaderRanking_Click(object sender, EventArgs e)
        {
            if (_paginaAtual?.Pagina is not PaginaRanking)
            {
                AbrirPaginaRanking(sender, EventArgs.Empty);
            }
        }

        private void ButtonHeaderPerfil_Click(object sender, EventArgs e)
        {
            if (_paginaAtual?.Pagina is not PaginaPerfil || _paginaAtual?.Propriedade != UsuarioAtual.Id)
            {
                AbrirPaginaPerfil(sender, UsuarioAtual.Id);
            }
        }

        private void ButtonHeaderConquista_Click(object sender, EventArgs e)
        {
            if (_paginaAtual?.Pagina is not PaginaConquistas)
            {
                AbrirPaginaConquistas();
            }
        }

        private void AoDesbloquearConquista(object? sender, ConquistaNotificacao conquista)
        {
            AntdUI.Notification.open(new AntdUI.Notification.Config(this)
            {
                Title = $"Conquista desbloqueada!",
                Text = $"Conquista: {conquista.Nome}\nDescrição: {conquista.Descricao}",
                Align = AntdUI.TAlignFrom.BR
            });

            //MessageBox.Show($"Conquista desbloqueada!\nConquista: {conquista.Nome}\nDescrição: {conquista.Descricao}");
        }
        
        private void DropdownUsuarioMenu_ItemClick(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not MenuOpcoes opcao) return;

            switch (opcao)
            {
                case MenuOpcoes.VerPerfil:
                    AbrirPaginaPerfil(null, UsuarioAtual.Id);
                    break;
                case MenuOpcoes.VerHistorico:
                    AbrirPaginaHistorico();
                    break;
                case MenuOpcoes.Configuracoes:
                    AbrirConfiguracoes();
                    break;
                case MenuOpcoes.Sair:
                    AbrirPaginaInicial(null, EventArgs.Empty);
                    break;
            }
        }
    }

    public class PaginaAtual
    {
        public UserControl? Pagina { get; set; }
        public int? Propriedade { get; set; }
    }
}
