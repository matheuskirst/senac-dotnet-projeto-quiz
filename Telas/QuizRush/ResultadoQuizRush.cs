using SenacQuizApp.Dtos.Historico;
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

namespace SenacQuizApp.Telas.QuizRush
{
    public partial class ResultadoQuizRush : UserControl
    {
        private readonly int _quizId;
        private readonly QuizDiarioService _quizService;

        public ResultadoQuizRush(int quizId, QuizDiarioService quizService)
        {
            _quizId = quizId;
            _quizService = quizService;

            InitializeComponent();
        }

        private async void ResultadoQuizRush_Load(object sender, EventArgs e)
        {
            try
            {
                QuizRushEntrada? resultado = await _quizService.ObterResultadorUSHPorId(_quizId);

                if (resultado == null) return;

                LabelDataInicio.Text = resultado.DataIniciado.ToString(@"dd/MM/yyyy HH\:mm\:ss");
                LabelDataConcluido.Text = resultado.DataConcluido?.ToString(@"dd/MM/yyyy HH\:mm\:ss") ?? "Não disponível";
                LabelStreak.Text = resultado.Streak.ToString();
                LabelPontuacaoTotal.Text = resultado.PontuacaoTotal.ToString();
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
