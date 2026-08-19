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
using Microsoft.EntityFrameworkCore.Metadata;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly UsuarioService _usuarioService;
        public event EventHandler? RealizarLogout;
        public event EventHandler? JogarQuizDiario;
        public PaginaPrincipal(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }


        private void ButtonPrincipalSair_Click_1(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonIniciarQuizDiario_Click(object sender, EventArgs e)
        {
            JogarQuizDiario?.Invoke(this, EventArgs.Empty);
        }
    }
}
