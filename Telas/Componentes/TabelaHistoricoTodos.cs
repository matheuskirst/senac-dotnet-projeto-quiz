using SenacQuizApp.Dtos.Historico;
using System.ComponentModel;

namespace SenacQuizApp.Telas.Componentes
{
    public class TabelaHistoricoTodos : AntdUI.Table
    {
        public TabelaHistoricoTodos()
        {
            this.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizGenerico.Tipo), "Tipo") { SortOrder = true },
                new AntdUI.Column(nameof(QuizGenerico.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                new AntdUI.Column(nameof(QuizGenerico.ConcluidoDisplay), "Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(QuizGenerico.DataConcluido), "Data Finalizado ") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                new AntdUI.Column(nameof(QuizGenerico.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                new AntdUI.Column(nameof(QuizGenerico.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
            };
        }
    }
}
