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

namespace SenacQuizApp.Features.Login
{
    public partial class PaginaLogin : UserControl
    {
        public event EventHandler? EscolheuVoltar;
        private readonly UsuarioService _usuarioService;

        public PaginaLogin(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLoginVoltar_Click(object sender, EventArgs e)
        {
            EscolheuVoltar?.Invoke(this, EventArgs.Empty);
        }
    }
}
