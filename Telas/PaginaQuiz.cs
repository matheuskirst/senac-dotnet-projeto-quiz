using SenacQuizApp.Entidades;
using SenacQuizApp.Enums;
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
        private readonly UsuarioLogado? _usuarioAtual;
        private readonly QuizEncontrado? _quizAtual;
        private List<PainelQuizPergunta> PaineisPerguntas;
        private int PerguntaAtualIndex;
        public event Action<int> RespondeuPergunta;
        public PaginaQuiz(UsuarioLogado? usuarioAtual, QuizEncontrado? quizAtual)
        {
            _usuarioAtual = usuarioAtual;
            _quizAtual = quizAtual;

            InitializeComponent();
        }

        private void PaginaQuiz_Load(object sender, EventArgs e)
        {
            if (_quizAtual != null)
            {
                List<PerguntasEncontradas> perguntas = _quizAtual.Perguntas;
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
            if (_quizAtual != null)
            {
                List<PerguntasEncontradas> perguntas = _quizAtual.Perguntas;
                int proximoIndex = PerguntaAtualIndex + 1;

                if (proximoIndex < perguntas.Count)
                {
                    PerguntasEncontradas? proximaPergunta = perguntas[proximoIndex];

                    PerguntaAtualIndex = perguntas.IndexOf(proximaPergunta);

                    PainelQuizPergunta proximoPainelPergunta = new PainelQuizPergunta(proximaPergunta, proximaPergunta.Alternativas);

                    proximoPainelPergunta.ClicouAlternativa += AoResponderPergunta;

                    PaineisPerguntas.Add(proximoPainelPergunta);
                }
                RespondeuPergunta?.Invoke(alternativaId);
            }
        }
    }
}
