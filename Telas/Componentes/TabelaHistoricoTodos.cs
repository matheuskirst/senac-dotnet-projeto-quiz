using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Telas.QuizDiario;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Telas.Componentes
{
    public class TabelaHistoricoTodos : AntdUI.Table
    {
        public TabelaHistoricoTodos(List<ResumoQuiz> quizzes)
        {
            this.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(ResumoQuiz.TipoId), "TipoId") { Visible = false },
                new AntdUI.Column(nameof(ResumoQuiz.Tipo), "Tipo") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.DataIniciado), "Data Iniciado") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.Finalizado), "Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.DataFinalizado), "Data Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.Tempo), "Tempo") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
            };

            var source = new BindingList<ResumoQuiz>(quizzes);

            this.DataSource = source;
        }
    }
}
