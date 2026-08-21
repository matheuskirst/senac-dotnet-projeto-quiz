using AntdUI;
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas
{
    public partial class FormApp : Window
    {
        private readonly AutenticacaoService _autenticacaoService;
        private readonly QuizExecucaoService _quizExecucaoService;

        public FormApp(AutenticacaoService autenticacaoService, QuizExecucaoService quizService)
        {
            _autenticacaoService = autenticacaoService;
            _quizExecucaoService = quizService;
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
                || pagina is PaginaQuiz
            )
            {
                PanelDropdownUsuario.Visible = false;
                PanelAppHeader.Visible = false;
            }
            else
            {
                PanelDropdownUsuario.Visible = true;
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
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            PaginaLogin paginaLogin = new PaginaLogin(_autenticacaoService);

            paginaLogin.EscolheuVoltar += AbrirPaginaInicial;
            paginaLogin.ConcluiuLogin += AoConcluirLogin;

            MudarPagina(paginaLogin);
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            PaginaSignup paginaSignup = new PaginaSignup(_autenticacaoService);

            paginaSignup.EscolheuVoltar += AbrirPaginaInicial;
            paginaSignup.ConcluiuSignup += AoConcluirLogin;

            MudarPagina(paginaSignup);
        }

        public void AbrirPaginaPrincipal(object? sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(_quizExecucaoService);

            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderMenu.Enabled = false;

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.JogarQuizDiario += AbrirPaginaQuiz;

            MudarPagina(paginaPrincipal);
        }

        public void AbrirPaginaQuiz(object? sender, EventArgs e)
        {
            PaginaQuiz paginaQuiz = new PaginaQuiz(_quizExecucaoService);

            MudarPagina(paginaQuiz);
        }

        public void AbrirPaginaPerfil(object? sender, EventArgs e)
        {
            PaginaPerfil paginaPerfil = new PaginaPerfil(_autenticacaoService);

            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderRanking.Enabled = true;

            ButtonHeaderPerfil.Enabled = false;

            MudarPagina(paginaPerfil);
        }

        public void AbrirPaginaRanking(object? sender, EventArgs e)
        {
            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderRanking.Enabled = false;

            PaginaRanking paginaRanking = new PaginaRanking();

            MudarPagina(paginaRanking);
        }

        private void AoConcluirLogin(object? sender, EventArgs e)
        {
            DropdownUsuario.Text = UsuarioAtual.Username;

            AbrirPaginaPrincipal(sender, EventArgs.Empty);
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
            AbrirPaginaPerfil(sender, EventArgs.Empty);
        }
    }
}
