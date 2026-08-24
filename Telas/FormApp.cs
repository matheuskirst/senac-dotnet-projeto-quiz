using AntdUI;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class FormApp : Window
    {
        private readonly AutenticacaoService _autenticacaoService;
        private readonly QuizService _quizService;

        public FormApp(AutenticacaoService autenticacaoService, QuizService quizService)
        {
            _autenticacaoService = autenticacaoService;
            _quizService = quizService;
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
            ButtonHeaderQuiz.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderMenu.Enabled = false;

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.JogarQuizDiario += AbrirPaginaQuiz;

            MudarPagina(paginaPrincipal);
        }

        public void AbrirPaginaQuiz(object? sender, EventArgs e)
        {
            ButtonHeaderRanking.Enabled = true;
            ButtonHeaderMenu.Enabled = true;
            ButtonHeaderPerfil.Enabled = true;

            ButtonHeaderQuiz.Enabled = false;
            var paginaQuiz = new PaginaQuiz(_quizService);

            paginaQuiz.VoltarParaOMenu += AbrirPaginaPrincipal;

            MudarPagina(paginaQuiz);
        }

        private void ButtonHeaderMenu_Click(object sender, EventArgs e)
        {
            AbrirPaginaPrincipal(sender, EventArgs.Empty);
        }

        private void ButtonHeaderQuiz_Click(object sender, EventArgs e)
        {
            AbrirPaginaQuiz(sender, EventArgs.Empty);
        }
    }
}
