using SenacQuizApp.Dtos.Historico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Telas.Componentes
{
    public class TabelaHistoricoDiario : AntdUI.Table
    {
        public TabelaHistoricoDiario(List<QuizDiarioHistorico> quizzes)
        {
            this.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizDiarioHistorico.Tipo), "Tipo"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataExibido), "Data Exibido"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataIniciado), "Data Iniciado"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.Concluido), "Concluído"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.DataConcluido), "Data Concluído"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TempoDeConclusao), "Tempo para concluir"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TotalQuestoes), "Total Questões"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.TotalAcertos), "Acertos"),
                new AntdUI.Column(nameof(QuizDiarioHistorico.PontuacaoTotal), "Pontuação Final"),
            };

            var source = new BindingList<QuizDiarioHistorico>(quizzes);

            this.DataSource = source;
        }
    }
}
