using AntdUI;
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas
{
    public partial class FormPrincipal : Window
    {
        private readonly UsuarioService _usuarioService;
        private readonly PerguntaService _perguntaService;

        public FormPrincipal(UsuarioService usuarioService, PerguntaService perguntaService)
        {
            _usuarioService = usuarioService;
            _perguntaService = perguntaService;

            InitializeComponent();
        }

        private async void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            AbrirPaginaInicial(null, e);
        }

        public void MudarPagina(UserControl pagina)
        {
            while (panelContainer.Controls.Count > 0)
            {
                var controle = panelContainer.Controls[0];
                panelContainer.Controls.Remove(controle);
                controle.Dispose();
            }

            pagina.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(pagina);
        }

        public void AbrirPaginaInicial(object? sender, EventArgs e)
        {
            _usuarioService.RealizarLogout();
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            PaginaLogin paginaLogin = new PaginaLogin(_usuarioService);

            paginaLogin.EscolheuVoltar += AbrirPaginaInicial;
            paginaLogin.ConcluiuLogin += AbrirPaginaPrincipal;

            MudarPagina(paginaLogin);
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            PaginaSignup paginaSignup = new PaginaSignup(_usuarioService);

            paginaSignup.EscolheuVoltar += AbrirPaginaInicial;
            paginaSignup.ConcluiuSignup += AbrirPaginaPrincipal;

            MudarPagina(paginaSignup);
        }

        public void AbrirPaginaPrincipal(object? sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(_usuarioService);

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.JogarQuizDiario += AbrirPaginaQuiz;
            paginaPrincipal.AbrirPerfil += AbrirPaginaPerfil;
            paginaPrincipal.AbrirRanking += AbrirPaginaQuiz;

            MudarPagina(paginaPrincipal);
        }

        public void AbrirPaginaQuiz(object? sender, EventArgs e)
        {
            PaginaQuiz paginaQuiz = new PaginaQuiz(_usuarioService, _perguntaService);

            MudarPagina(paginaQuiz);
        }

        public void AbrirPaginaPerfil(object? sender, EventArgs e)
        {
            PaginaPerfil paginaPerfil = new PaginaPerfil(_usuarioService, _perguntaService);

            paginaPerfil.VoltarParaMenu += AbrirPaginaPrincipal;

            MudarPagina(paginaPerfil);
        }

        public void AbrirPaginaRanking(object? sender, EventArgs e)
        {
            PaginaRanking paginaRanking = new PaginaRanking(_usuarioService, _perguntaService);

            MudarPagina(paginaRanking);
        }
    }
}
