using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using SenacQuizApp.Modelos;
using SenacQuizApp.Services;
using SenacQuizApp.Telas;
using SenacQuizApp.Telas.Eventos;
using SenacQuizApp.Enums;
using SenacQuizApp.Banco.Repositories;

namespace SenacQuizApp.Telas
{
    public partial class FormPrincipal : Window
    {
        private readonly UsuarioService _usuarioService;
        private readonly QuizService _quizService;
        private readonly PerguntaService _perguntaService;

        public FormPrincipal(UsuarioService usuarioService, QuizService quizService, PerguntaService perguntaService)
        {
            _usuarioService = usuarioService;
            _quizService = quizService;
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
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(_usuarioService, _quizService);

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.ClicouJogarQuizDiario += AbrirPaginaQuiz;

            MudarPagina(paginaPrincipal);
        }

        public void AbrirPaginaQuiz(object? sender, EventArgs e)
        {
            PaginaQuiz paginaQuiz = new PaginaQuiz(_usuarioService, _quizService);

            MudarPagina(paginaQuiz);
        }

        private async void AoFinalizarQuiz(object? sender, SignupEventArgs e)
        {

        }
    }
}
