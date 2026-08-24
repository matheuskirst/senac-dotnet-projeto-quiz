using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;
using SenacQuizApp.Dtos.Quiz;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly QuizService _quizService;
        private QuizSessao? _quizSessao;

        public event EventHandler? VoltarParaOMenu;
        public PaginaQuiz(QuizService quizService)
        {
            _quizService = quizService;

            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {
            try
            {
                QuizDto? quiz = await _quizService.ObterQuizDiario();

                if (quiz != null)
                {
                    if (quiz.FoiConcluido)
                    {
                        MessageBox.Show(
                            "O quiz diário já foi concluido.",
                            "Quiz já concluido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        VoltarParaOMenu?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        _quizSessao = new QuizSessao 
                        { 
                            Quiz = quiz,
                            QuestaoAtualIndex = 0,
                            SequenciaAcertos = 0
                        };
                    }
                }

            }
            catch
            {
                MessageBox.Show(
                    "Ocorreu um erro ao se conectar com o servidor.",
                    "Erro de Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                VoltarParaOMenu?.Invoke(this, EventArgs.Empty);
            }
        }

        private void MudarPainel(PainelQuestoes painel)
        {
            while (PanelQuestoes.Controls.Count > 0)
            {
                var controle = PanelQuestoes.Controls[0];
                PanelQuestoes.Controls.Remove(controle);
                controle.Dispose();
            }
            PanelQuestoes.Controls.Add(painel);
        }

        private void ProximaQuestao()
        {
            var questao = new PainelQuestoes(_quizSessao.Quiz.Questoes);
        }
    }

    public class QuizSessao
    {
        public QuizDto Quiz { get; set; } = null!;
        public int QuestaoAtualIndex { get; set; }
        public int SequenciaAcertos { get; set; }
    }
}
