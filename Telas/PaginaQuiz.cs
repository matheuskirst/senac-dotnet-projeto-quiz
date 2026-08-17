using SenacQuizApp.Entidades;
using SenacQuizApp.Modelos;
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
    public partial class PaginaQuiz : UserControl
    {
        public readonly UsuarioDto? _usuarioAtual;
        public readonly QuizDto? _quizAtual;
        public PaginaQuiz(UsuarioDto? usuarioAtual, QuizDto? quizAtual)
        {
            _usuarioAtual = usuarioAtual;
            _quizAtual = quizAtual;

            InitializeComponent();
        }

        private void PaginaQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
