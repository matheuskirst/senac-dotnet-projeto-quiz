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
using ReaLTaiizor.Forms;

namespace SenacQuizApp.Features.TelaPrincipal
{
    public partial class FormJanelaPrincipal : Form
    {
        private readonly UsuarioService _usuarioService;

        public FormJanelaPrincipal()
        {
            UsuarioService usuarioService = new UsuarioService();
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            AbrirPaginaInicial();
        }

        public void MudarPagina(UserControl pagina)
        {
            panelContainer.Controls.Clear();

            pagina.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(pagina);
        }

        public void AbrirPaginaInicial()
        {
            PaginaInicial.PaginaInicial paginaInicial = new PaginaInicial.PaginaInicial();

            paginaInicial.EscolheuLogin += AbrirPaginaLogin;
            paginaInicial.EscolheuSignup += AbrirPaginaSignup;

            MudarPagina(paginaInicial);
        }

        public void AbrirPaginaLogin(object? sender, EventArgs e)
        {
            PaginaLogin paginaLogin = new PaginaLogin(_usuarioService);

            MudarPagina(paginaLogin);
        }

        public void AbrirPaginaSignup(object? sender, EventArgs e)
        {
            PaginaSignup paginaSignup = new PaginaSignup(_usuarioService);

            MudarPagina(paginaSignup);
        }
    }
}
