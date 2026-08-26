using AntdUI;
using Microsoft.EntityFrameworkCore.Metadata;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class FormApp : Window
    {
        private readonly AutenticacaoService _autenticacaoService;
        private readonly QuizService _quizService;
        private readonly UsuarioPerfilService _usuarioPerfilService;
        private readonly RankingService _rankingService;

        public FormApp(AutenticacaoService autenticacaoService, QuizService quizService, UsuarioPerfilService usuarioPerfilService, RankingService rankingService)
        {
            _autenticacaoService = autenticacaoService;
            _quizService = quizService;
            _usuarioPerfilService = usuarioPerfilService;
            _rankingService = rankingService;
            InitializeComponent();
        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            AbrirPaginaInicial(null, e);
        }

        public void MudarPagina(UserControl pagina)
        {
            if (pagina is PaginaInicial
                || pagina is PaginaLogin
                || pagina is PaginaSignup
            )
            {
                PanelAppHeader.Visible = false;
            }
            else
            {
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
            var paginaPrincipal = new PaginaPrincipal(_quizService);

            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderMenu.Enabled = false;

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.AbrirQuizDiario += AbrirPaginaQuiz;

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

        public void AbrirPaginaPerfil(int usuarioId)
        {
            var paginaPerfil = new PaginaPerfil(usuarioId, _usuarioPerfilService);

            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderRanking.Enabled = true;

            ButtonHeaderPerfil.Enabled = false;

            MudarPagina(paginaPerfil);
        }

        public void AbrirPaginaQuiz(int quizId)
        {
            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            var paginaQuiz = new PaginaQuiz(quizId, _quizService, _usuarioPerfilService);

            paginaQuiz.VoltarParaOMenu += AbrirPaginaPrincipal;

            MudarPagina(paginaQuiz);
        }

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
    }
}
