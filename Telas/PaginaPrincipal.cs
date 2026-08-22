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
using SenacQuizApp.Dtos;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly QuizExecucaoService _quizExecucaoService;

        public event EventHandler? RealizarLogout;
        public event EventHandler? JogarQuizDiario;
        public PaginaPrincipal(QuizExecucaoService quizExecucaoService)
        {
            _quizExecucaoService = quizExecucaoService;

            InitializeComponent();
        }

        private async void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonIniciarQuizDiario_Click(object sender, EventArgs e)
        {
            JogarQuizDiario?.Invoke(this, EventArgs.Empty);
        }
    }
}
