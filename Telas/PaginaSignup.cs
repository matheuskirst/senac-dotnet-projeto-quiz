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

namespace SenacQuizApp.Features.Cadastro
{
    public partial class PaginaSignup : UserControl
    {
        public event EventHandler? EscolheuVoltar;
        private readonly UsuarioService _usuarioService;
        public PaginaSignup(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private void PaginaSignup_Load(object sender, EventArgs e)
        {
            DatePickerSignupDataNascimento.MaxDate = DateTime.Now;
        }

        private void ButtonSignupVoltar_Click(object sender, EventArgs e)
        {
            EscolheuVoltar?.Invoke(this, EventArgs.Empty);
        }
    }
}
