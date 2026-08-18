using SenacQuizApp.Banco.Entidades;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;
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
        private readonly UsuarioDto? _usuarioAtual;
        private readonly QuizDto? _quizAtual;
        private readonly List<PainelQuizPergunta> PaineisPerguntas;
        public PaginaQuiz(UsuarioDto? usuarioAtual, QuizDto? quizAtual)
        {
            _usuarioAtual = usuarioAtual;
            _quizAtual = quizAtual;

            InitializeComponent();
        }

        private void PaginaQuiz_Load(object sender, EventArgs e)
        {
            foreach(PerguntaDto pergunta in _quizAtual.Perguntas)
            {
                PainelQuizPergunta painelPergunta = new PainelQuizPergunta(pergunta, pergunta.Alternativas);
                PaineisPerguntas.Add(painelPergunta);
            }
        }
    }
}
