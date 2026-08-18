using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenacQuizApp.Services;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly UsuarioLogado? _usuarioAtual;
        public event EventHandler? RealizarLogout;
        public event EventHandler? ClicouJogarQuizDiario;
        public PaginaPrincipal(UsuarioLogado? usuarioAtual)
        {
            _usuarioAtual = usuarioAtual ?? throw new ArgumentNullException(nameof(usuarioAtual));

            InitializeComponent();
        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonJogarQuiz_Click(object sender, EventArgs e)
        {
            ClicouJogarQuizDiario?.Invoke(this, EventArgs.Empty);
        }
    }
}
