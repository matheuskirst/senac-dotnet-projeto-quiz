using SenacQuizApp.Entidades;
using SenacQuizApp.Services;
using SenacQuizApp.Telas;
using SenacQuizApp.Telas.Eventos;
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
using SenacQuizApp.Services.Enums;

namespace SenacQuizApp.Telas
{
    public partial class FormPrincipal : Window
    {
        private readonly UsuarioService _usuarioService;
        public Usuario? UsuarioAtual { get; private set; }

        public FormPrincipal()
        {
            UsuarioService usuarioService = new UsuarioService();
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            AbrirPaginaInicial(null, e);
        }

        public void MudarPagina(UserControl pagina)
        {
            panelContainer.Controls.Clear();

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

            MudarPagina(paginaPrincipal);
        }

        private async void AoRequisitarLogin(object? sender, LoginEventArgs e)
        {
            var paginaLogin = (PaginaLogin?)sender;
            try
            {
                ResultadoAuth resultado = await _usuarioService.RealizarLogin(e.Nome,  e.Senha);

                if (resultado.EhSucesso)
                {
                    UsuarioAtual = resultado.Usuario;
                    AbrirPaginaPrincipal(this, EventArgs.Empty);
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
                ResultadoAuth resultado = await _usuarioService.RealizarSignup(e.Nome, e.Nick, e.DataNascimento, e.Senha);

                if (resultado.EhSucesso)
                {
                    UsuarioAtual = resultado.Usuario;
                    AbrirPaginaPrincipal(this, EventArgs.Empty);
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
    }
}
