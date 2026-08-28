using AntdUI;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;
using SenacQuizApp.Telas.Componentes.Quiz;
using SenacQuizApp.Telas.QuizDiario;

namespace SenacQuizApp.Telas
{
    public partial class FormApp : Window
    {
        private readonly AutenticacaoService _autenticacaoService;
        private readonly QuizDiarioService _quizDiarioService;
        private readonly UsuarioService _usuarioPerfilService;
        private readonly RankingService _rankingService;
        private readonly HistoricoService _historicoService;
        private readonly ConquistaService _conquistaService;

        public FormApp(
            AutenticacaoService autenticacaoService,
            QuizDiarioService quizDiarioService,
            UsuarioService usuarioPerfilService,
            RankingService rankingService,
            HistoricoService historicoService,
            ConquistaService conquistaService
            )
        {
            _autenticacaoService = autenticacaoService;
            _quizDiarioService = quizDiarioService;
            _usuarioPerfilService = usuarioPerfilService;
            _rankingService = rankingService;
            _historicoService = historicoService;
            _conquistaService = conquistaService;

            _conquistaService.ConquistaDesbloqueada += AoDesbloquearConquista;
            InitializeComponent();

            SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true);
            UpdateStyles();
        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            var dropdownItems = new object[]
            {
                new AntdUI.SelectItem("Ver Perfil") { Tag = MenuOpcoes.VerPerfil },
                new AntdUI.SelectItem("Configurações") { Tag = MenuOpcoes.Configuracoes, },
                new AntdUI.SelectItem("Sair...") { Tag = MenuOpcoes.Sair }
            };

            DropdownUsuarioMenu.Items.AddRange(dropdownItems);

            AbrirPaginaInicial(null, e);
        }

        public void MudarPagina(UserControl pagina)
        {
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
        }

        public void AbrirPaginaInicial(object? sender, EventArgs e)
        {
            _autenticacaoService.RealizarLogout();
            var paginaInicial = new PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            var paginaLogin = new PaginaLogin(_autenticacaoService);

            paginaLogin.EscolheuVoltar += AbrirPaginaInicial;
            paginaLogin.ConcluiuLogin += AoConcluirLogin;

            MudarPagina(paginaLogin);
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            var paginaSignup = new PaginaSignup(_autenticacaoService);

            paginaSignup.EscolheuVoltar += AbrirPaginaInicial;
            paginaSignup.ConcluiuSignup += AoConcluirLogin;

            MudarPagina(paginaSignup);
        }
        private void AoConcluirLogin(object? sender, EventArgs e)
        {
            AbrirPaginaPrincipal(sender, EventArgs.Empty);
        }

        public void AbrirPaginaPrincipal(object? sender, EventArgs e)
        {
            var paginaPrincipal = new PaginaPrincipal(_quizDiarioService, _historicoService);

            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderMenu.Enabled = false;

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.AbrirHubQuizDiario += AbrirHubQuizDiario;

            paginaPrincipal.ContinuarQuizDiario += AbrirExecutarQuizDiario;
            paginaPrincipal.ResultadoQuizDiario += AbrirResultadoQuizDiario;

            MudarPagina(paginaPrincipal);
        }

        public void AbrirPaginaRanking(object? sender, EventArgs e)
        {
            var paginaRanking = new PaginaRanking(_rankingService);

            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderRanking.Enabled = false;

            paginaRanking.AbrirPerfil += AbrirPaginaPerfil;

            MudarPagina(paginaRanking);
        }

        public void AbrirPaginaHistorico()
        {
            var paginaHistorico = new PaginaHistorico(_historicoService);

            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            MudarPagina(paginaHistorico);
        }

        public void AbrirPaginaPerfil(int usuarioId)
        {
            var paginaPerfil = new PaginaPerfil(usuarioId, _usuarioPerfilService);

            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderRanking.Enabled = true;

            ButtonHeaderPerfil.Enabled = false;

            MudarPagina(paginaPerfil);
        }

        // ============================================================
        // Quiz Diário
        // ============================================================

        public void AbrirHubQuizDiario(object? sender, EventArgs e)
        {
            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            var hubQuizDiario = new HubQuizDiario(_quizDiarioService, _usuarioPerfilService);

            hubQuizDiario.IniciarQuiz += AbrirExecutarQuizDiario;
            hubQuizDiario.VerResultado += AbrirResultadoQuizDiario;
            hubQuizDiario.CarregarQuiz += AbrirExecutarQuizDiario;

            MudarPagina(hubQuizDiario);
        }

        public void AbrirExecutarQuizDiario(int quizId)
        {
            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            var executarQuizDiario = new ExecutarQuizDiario(quizId, _quizDiarioService, _usuarioPerfilService);

            executarQuizDiario.VerResultado += AbrirResultadoQuizDiario;

            MudarPagina(executarQuizDiario);
        }

        public void AbrirResultadoQuizDiario(int quizId)
        {
            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            var resultadoQuizDiario = new ResultadoQuizDiario(quizId, _quizDiarioService);

            MudarPagina(resultadoQuizDiario);
        }


        // ============================================================
        // Botões Header
        // ============================================================

        private void ButtonHeaderMenu_Click(object sender, EventArgs e)
        {
            AbrirPaginaPrincipal(sender, EventArgs.Empty);
        }

        private void ButtonHeaderRanking_Click(object sender, EventArgs e)
        {
            AbrirPaginaRanking(sender, EventArgs.Empty);
        }

        private void ButtonHeaderPerfil_Click(object sender, EventArgs e)
        {
            AbrirPaginaPerfil(UsuarioAtual.Id);
        }

        private void AoDesbloquearConquista(object? sender, ConquistaDto conquista)
        {
            MessageBox.Show($"Conquista desbloqueada!\nConquista: {conquista.Nome}\nDescrição: {conquista.Descricao}");
        }

        private void DropdownUsuarioMenu_ItemClick(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not MenuOpcoes opcao) return;

            switch (opcao)
            {
                case MenuOpcoes.VerPerfil:
                    AbrirPaginaPerfil(UsuarioAtual.Id);
                    break;
                case MenuOpcoes.Configuracoes:

                    break;
                case MenuOpcoes.Sair:
                    AbrirPaginaInicial(null, EventArgs.Empty);
                    break;
            }
        }
    }
}
