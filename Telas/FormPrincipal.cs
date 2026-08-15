using SenacQuizApp.Features.Cadastro;
using SenacQuizApp.Features.Login;
using SenacQuizApp.Features.PaginaInicial;
using SenacQuizApp.Services;
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
using SenacQuizApp.Telas;

namespace SenacQuizApp.Features.TelaPrincipal
{
    public partial class FormPrincipal : Window
    {
        private readonly UsuarioService _usuarioService;

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
            PaginaInicial.PaginaInicial paginaInicial = new PaginaInicial.PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            PaginaLogin paginaLogin = new PaginaLogin(_usuarioService);

            paginaLogin.EscolheuVoltar += AbrirPaginaInicial;

            MudarPagina(paginaLogin);
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            PaginaSignup paginaSignup = new PaginaSignup(_usuarioService);

            paginaSignup.EscolheuVoltar += AbrirPaginaInicial;

            MudarPagina(paginaSignup);
        }

        public void AbrirPaginaPrincipal(object? sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(_usuarioService);

            MudarPagina(paginaPrincipal);
        }
    }
}
