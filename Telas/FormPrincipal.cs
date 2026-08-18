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

        public UsuarioLogado? UsuarioAtual { get; private set; }
        public QuizEncontrado? QuizAtual { get; private set; }

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
            UsuarioAtual = null;
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            PaginaLogin paginaLogin = new PaginaLogin();

            paginaLogin.EscolheuVoltar += AbrirPaginaInicial;
            paginaLogin.RequesitouLogin += AoRequisitarLogin;

            MudarPagina(paginaLogin);
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            PaginaSignup paginaSignup = new PaginaSignup();

            paginaSignup.EscolheuVoltar += AbrirPaginaInicial;
            paginaSignup.RequesitouSignup += AoRequisitarSignup;

            MudarPagina(paginaSignup);
        }

        public void AbrirPaginaPrincipal(object? sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(UsuarioAtual);

            paginaPrincipal.RealizarLogout += AbrirPaginaInicial;
            paginaPrincipal.ClicouJogarQuizDiario += AbrirPaginaQuiz;

            MudarPagina(paginaPrincipal);
        }

        public void AbrirPaginaQuiz(object? sender, EventArgs e)
        {
            PaginaQuiz paginaQuiz = new PaginaQuiz(UsuarioAtual, QuizAtual);

            MudarPagina(paginaQuiz);
        }

        private async void AoRequisitarLogin(object? sender, LoginEventArgs e)
        {
            var paginaLogin = (PaginaLogin?)sender;
            try
            {
                LoginInput login = new(Username: e.Username, Senha: e.Senha);

                LoginResposta resultado = await _usuarioService.RealizarLogin(login);

                if (resultado.IsSucesso == true)
                {
                    UsuarioAtual = resultado.Usuario;
                    AoRealizarLogin();
                }
                else
                {
                    if (resultado.MensagemErro == MensagemErro.LoginInvalido)
                    {
                        paginaLogin?.ErroNoLogin();
                    }
                }
            }
            catch (Exception ex)
            {
                paginaLogin?.ErroDeConexao(ex.ToString());
            }
        }

        private async void AoRequisitarSignup(object? sender, SignupEventArgs e)
        {
            var paginaSignup = (PaginaSignup?)sender;
            try
            {
                LoginResposta resultado = await _usuarioService.RealizarSignup(e.Nome, e.Nick, e.DataNascimento, e.Senha);

                if (resultado.IsSucesso == true && resultado.Usuario != null)
                {
                    UsuarioAtual = resultado.Usuario;
                    AoRealizarLogin();
                }
                else
                {
                    if (resultado.MensagemErro == MensagemErro.NomeIndisponivel)
                    {
                        paginaSignup?.NomeIndisponivel();
                    }
                }
            }
            catch (Exception ex)
            {
                paginaSignup?.ErroDeConexao(ex.ToString());
            }
        }

        private async void AoRealizarLogin()
        {

            AbrirPaginaPrincipal(this, EventArgs.Empty);
        }

        private async void AoFinalizarQuiz(object? sender, SignupEventArgs e)
        {

        }
    }
}
