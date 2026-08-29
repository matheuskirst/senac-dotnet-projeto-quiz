using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Dtos.QuizRush;

namespace SenacQuizApp.Telas.Componentes
{
    public class TabelaHistoricoRush : AntdUI.Table
    {
        public TabelaHistoricoRush(List<QuizRushEntrada> quizzes)
        {
            this.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizRushEntrada.Tipo), "Tipo"),
                new AntdUI.Column(nameof(QuizRushEntrada.DataIniciado), "Data Iniciado"),
                new AntdUI.Column(nameof(QuizRushEntrada.DataFinalizado), "Data Finalizado"),
                new AntdUI.Column(nameof(QuizRushEntrada.Tempo), "Tempo"),
                new AntdUI.Column(nameof(QuizRushEntrada.Streak), "Streak"),
                new AntdUI.Column(nameof(QuizRushEntrada.PontuacaoTotal), "Pontuação Total")
            };

            var source = new BindingList<QuizRushEntrada>(quizzes);

            this.DataSource = source;
        }
    }
}
