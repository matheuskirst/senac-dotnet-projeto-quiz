using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizRush;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class HistoricoQuizRush : UserControl
    {
        private readonly BindingList<QuizRushEntrada> _quizList = [];
        public HistoricoQuizRush(List<QuizRushEntrada> quizzes)
        {
            InitializeComponent();

            TableQuizHistorico.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizRushEntrada.Tipo), "Tipo"),
                new AntdUI.Column(nameof(QuizRushEntrada.DataIniciado), "Data Iniciado"),
                new AntdUI.Column(nameof(QuizRushEntrada.DataFinalizado), "Data Finalizado"),
                new AntdUI.Column(nameof(QuizRushEntrada.Tempo), "Tempo"),
                new AntdUI.Column(nameof(QuizRushEntrada.Streak), "Streak"),
                new AntdUI.Column(nameof(QuizRushEntrada.PontuacaoTotal), "Pontuação Total")
            };
            TableQuizHistorico.DataSource = _quizList;
        }

        private void AtualizarTabelaQuizzes(List<QuizRushEntrada> quizzes)
        {
            TableQuizHistorico.PauseLayout = true;
            try
            {
                _quizList.Clear();

                foreach (QuizRushEntrada quiz in quizzes)
                {
                    _quizList.Add(quiz);
                }
            }
            finally
            {
                TableQuizHistorico.PauseLayout = false;
                TableQuizHistorico.Refresh();
            }
        }
    }
}
