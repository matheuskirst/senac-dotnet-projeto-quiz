using SenacQuizApp.Entidades;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos;
using SenacQuizApp.Services;
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
        private readonly UsuarioService? _usuarioService;
        private readonly QuizService? _quizService;
        private List<PainelQuizPergunta>? PaineisPerguntas;
        private int PerguntaAtualIndex;
        public PaginaQuiz(UsuarioService? usuarioService, QuizService quizService)
        {
            _usuarioService = usuarioService;
            _quizService = quizService;

            InitializeComponent();
        }

        private void PaginaQuiz_Load(object sender, EventArgs e)
        {
            if (_quizService.QuizAtual != null)
            {
                List<PerguntasEncontradas> perguntas = _quizService.QuizAtual.Perguntas;
                PerguntasEncontradas? pergunta = perguntas.FirstOrDefault();
                if (pergunta != null)
                {
                    PerguntaAtualIndex = perguntas.IndexOf(pergunta);

                    PainelQuizPergunta painelPergunta = new PainelQuizPergunta(pergunta, pergunta.Alternativas);

                    painelPergunta.ClicouAlternativa += AoResponderPergunta;

                    PaineisPerguntas.Add(painelPergunta);
                }
            }
        }

        private void AoResponderPergunta(int alternativaId)
        {
            if (_quizService.QuizAtual != null)
            {
                List<PerguntasEncontradas> perguntas = _quizService.QuizAtual.Perguntas;
                int proximoIndex = PerguntaAtualIndex + 1;

                if (proximoIndex < perguntas.Count)
                {
                    PerguntasEncontradas? proximaPergunta = perguntas[proximoIndex];

                    PerguntaAtualIndex = perguntas.IndexOf(proximaPergunta);

                    PainelQuizPergunta proximoPainelPergunta = new PainelQuizPergunta(proximaPergunta, proximaPergunta.Alternativas);

                    proximoPainelPergunta.ClicouAlternativa += AoResponderPergunta;

                    PaineisPerguntas.Add(proximoPainelPergunta);
                }
            }
        }
    }
}
