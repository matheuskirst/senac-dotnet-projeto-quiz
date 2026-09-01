using SenacQuizApp.Dtos;
using System.ComponentModel;

namespace SenacQuizApp.Telas.Componentes
{
    public class TabelaHistoricoTodos : AntdUI.Table
    {
        public TabelaHistoricoTodos()
        {
            this.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizResumo.Tipo), "Tipo") { SortOrder = true },
                new AntdUI.Column(nameof(QuizResumo.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                new AntdUI.Column(nameof(QuizResumo.ConcluidoDisplay), "Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(QuizResumo.DataConcluido), "Data Finalizado ") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                new AntdUI.Column(nameof(QuizResumo.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                new AntdUI.Column(nameof(QuizResumo.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
            };
        }
    }
}
