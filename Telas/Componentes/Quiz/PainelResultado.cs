using SenacQuizApp.Dtos.Quiz.Concluido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas.Componentes.Quiz
{
    public partial class PainelResultado : UserControl
    {
        private readonly QuizConcluidoDto _quiz;
        public PainelResultado(QuizConcluidoDto quiz)
        {
            _quiz = quiz;

            InitializeComponent();
        }

        private void PainelResultado_Load(object sender, EventArgs e)
        {
            LabelDataInicio.Text = _quiz.DataInicio.ToString();
            LabelDataExibido.Text = _quiz.DataExibido.ToString();
            LabelDataConcluido.Text = _quiz.DataConcluido.ToString();
            LabelTempoDeConclusao.Text = _quiz.TempoDeConclusao.ToString();
            LabelTotalQuestoes.Text = _quiz.TotalQuestoes.ToString();
            LabelTotalAcertos.Text = _quiz.TotalAcertos.ToString();
            LabelPontuacaoTotal.Text = _quiz.PontuacaoTotal.ToString();
        }
    }
}
