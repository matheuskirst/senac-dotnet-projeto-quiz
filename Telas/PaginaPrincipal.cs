using SenacQuizApp.Services;
using SenacQuizApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly Usuario? _usuarioAtual;
        public event EventHandler? RealizarLogout;
        public PaginaPrincipal(Usuario? usuarioAtual)
        {
            _usuarioAtual = usuarioAtual ?? throw new ArgumentNullException(nameof(usuarioAtual));

            InitializeComponent();
        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }
    }
}
