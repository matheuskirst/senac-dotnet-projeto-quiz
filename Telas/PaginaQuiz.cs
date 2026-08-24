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
using static SenacQuizApp.Global.ModelosConstantes;

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
                            MessageBoxIcon.Warning
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
                        ProximaQuestao();
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

        private async void ProximaQuestao()
        {
            if (_quizSessao != null)
            {
                int index = _quizSessao.QuestaoAtualIndex;
                var questao = _quizSessao.Quiz.Questoes[index];
                var painelQuestao = new PainelQuestoes(questao);

                if (index >= _quizSessao.Quiz.Questoes.Count - 1)
                {
                    await FinalizarQuiz();
                }
                else
                {
                    if (questao.Respondida)
                    {
                        ProximaQuestao();
                    }

                    painelQuestao.Dock = DockStyle.Fill;
                    painelQuestao.EscolheuAlternativa += AoResponder;
                    painelQuestao.EscolheuVerdadeiro += AoResponder;

                    MudarPainel(painelQuestao);
                }
            }
        }

        private async void AoResponder(int alternativaId)
        {
            if (_quizSessao != null)
            {
                int quizId = _quizSessao.Quiz.Id;
                int index = _quizSessao.QuestaoAtualIndex;
                var questao = _quizSessao.Quiz.Questoes[index];
                int sequenciaAcertos = _quizSessao.SequenciaAcertos;

                bool correta = await _quizService.SalvarResposta(quizId, questao, sequenciaAcertos, alternativaId: alternativaId);

                if (correta)
                {
                    _quizSessao.SequenciaAcertos++;
                }
                if (index < _quizSessao.Quiz.Questoes.Count - 1)
                {
                    _quizSessao.QuestaoAtualIndex++;
                }
                ProximaQuestao();
            }
        }        
        
        private async void AoResponder(bool verdadeira)
        {
            if (_quizSessao != null)
            {
                int quizId = _quizSessao.Quiz.Id;
                int index = _quizSessao.QuestaoAtualIndex;
                var questao = _quizSessao.Quiz.Questoes[index];
                int sequenciaAcertos = _quizSessao.SequenciaAcertos;

                bool correta = await _quizService.SalvarResposta(quizId, questao, sequenciaAcertos, verdadeiro: verdadeira);

                if (correta)
                {
                    _quizSessao.SequenciaAcertos++;
                }
                if (index < _quizSessao.Quiz.Questoes.Count - 1)
                {
                    _quizSessao.QuestaoAtualIndex++;
                }
                ProximaQuestao();
            }
        }

        private async Task FinalizarQuiz()
        {
            if (_quizSessao != null)
            {
                await _quizService.ConcluirQuiz(_quizSessao.Quiz.Id);
                MessageBox.Show(
                    "O quiz foi concluido.",
                    "Quiz concluido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                VoltarParaOMenu?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public class QuizSessao
    {
        public QuizDto Quiz { get; set; } = null!;
        public int QuestaoAtualIndex { get; set; }
        public int SequenciaAcertos { get; set; }
    }
}
