using AntdUI;
using Microsoft.VisualBasic;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class PaginaHistorico : UserControl
    {
        private readonly HistoricoService _historicoService;
        public event Action<int>? ContinuarQuiz;
        public event Action<int>? VerResultado;

        private AntdUI.ContextMenuStripItem _continuarItem;
        private AntdUI.ContextMenuStripItem _resultadoItem;
        private AntdUI.ContextMenuStripItem _copiarItem;
        private AntdUI.IContextMenuStripItem[] _menuItems;

        private QuizStatus _statusAtual;
        private QuizTipo _tipoAtual;

        public PaginaHistorico(HistoricoService historicoService)
        {
            _historicoService = historicoService;

            _continuarItem = new AntdUI.ContextMenuStripItem("Continuar")
            {
                Tag = "Continuar"
            };
            _resultadoItem = new AntdUI.ContextMenuStripItem("Ver Resultado")
            {
                Tag = "Resultado"
            };
            _copiarItem = new AntdUI.ContextMenuStripItem("Copiar dados")
            {
                Tag = "Copiar"
            };

            _menuItems =
            [
                _continuarItem,
                _resultadoItem,
                new AntdUI.ContextMenuStripItemDivider(),
                _copiarItem
            ];

            InitializeComponent();
        }

        private async void PaginaHistorico_Load(object sender, EventArgs e)
        {
            SelectQuizTipo.Items.Add(new AntdUI.SelectItem("Todos", QuizTipo.Todos));
            SelectQuizTipo.Items.Add(new AntdUI.SelectItem("Diário", QuizTipo.Diario));
            SelectQuizTipo.Items.Add(new AntdUI.SelectItem("Rush", QuizTipo.Rush));

            SelectQuizTipo.SelectedValue = QuizTipo.Todos;

            SelectStatus.Items.Add(new AntdUI.SelectItem("Todos", QuizStatus.Todos));
            SelectStatus.Items.Add(new AntdUI.SelectItem("Concluído", QuizStatus.Concluido));
            SelectStatus.Items.Add(new AntdUI.SelectItem("Não concluído", QuizStatus.NaoConcluido));

            SelectStatus.SelectedValue = QuizTipo.Todos;

            await CarregarTabelaTodos();
        }

        private async Task CarregarTabelaTodos(DateTime? minDate = null, DateTime? maxDate = null)
        {
            try
            {
                _tipoAtual = QuizTipo.Todos;
                LabelStatus.Visible = false;
                SelectStatus.Visible = false;

                TableHistorico.PauseLayout = true;

                List<QuizResumo> quizzes = await _historicoService.ObterTodos(minDate, maxDate);
                if (quizzes == null) return;

                TableHistorico.Columns = new AntdUI.ColumnCollection
                {
                    new AntdUI.Column(nameof(QuizResumo.Tipo), "Tipo") { SortOrder = true },
                    new AntdUI.Column(nameof(QuizResumo.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                    new AntdUI.Column(nameof(QuizResumo.ConcluidoDisplay), "Concluído ") { SortOrder = true },
                    new AntdUI.Column(nameof(QuizResumo.DataConcluido), "Data Concluído ") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                    new AntdUI.Column(nameof(QuizResumo.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                    new AntdUI.Column(nameof(QuizResumo.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
                };


                TableHistorico.DataSource = null;
                TableHistorico.DataSource = quizzes;
            }
            catch
            {

            }
            finally
            {
                TableHistorico.PauseLayout = false;
            }
        }
        private async Task CarregarTabelaDiario(DateTime? minDate = null, DateTime? maxDate = null)
        {
            try
            {
                _tipoAtual = QuizTipo.Diario;
                LabelStatus.Visible = true;
                SelectStatus.Visible = true;

                var status = _statusAtual;

                List<QuizDiarioHistorico> quizzes = await _historicoService.ObterHistoricosDiario(status, minDate, maxDate);

                if (quizzes == null) return;

                var tabela = new TabelaHistoricoDiario(quizzes);

                TableHistorico.Columns = new AntdUI.ColumnCollection
                {
                    new AntdUI.Column(nameof(QuizDiarioHistorico.Tipo), "Tipo") { SortOrder = true },
                    new AntdUI.Column(nameof(QuizDiarioHistorico.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                    new AntdUI.Column(nameof(QuizDiarioHistorico.ConcluidoDisplay), "Concluído"),
                    new AntdUI.Column(nameof(QuizDiarioHistorico.DataConcluido), "Data Concluído") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                    new AntdUI.Column(nameof(QuizDiarioHistorico.TempoDeConclusao), "Tempo para concluir") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                    new AntdUI.Column(nameof(QuizDiarioHistorico.TotalQuestoes), "Total Questões"),
                    new AntdUI.Column(nameof(QuizDiarioHistorico.TotalAcertos), "Acertos"),
                    new AntdUI.Column(nameof(QuizDiarioHistorico.PontuacaoTotal), "Pontuação Final"),
                };


                TableHistorico.DataSource = null;
                TableHistorico.DataSource = quizzes;
            }
            catch
            {

            }
        }

        private async Task CarregarTabelaRush(DateTime? minDate = null, DateTime? maxDate = null)
        {
            try
            {
                _tipoAtual = QuizTipo.Rush;
                LabelStatus.Visible = false;
                SelectStatus.Visible = false;

                List<QuizRushEntrada> quizzes = await _historicoService.ObterEntradasRush(minDate, maxDate);

                if (quizzes == null) return;

                var tabela = new TabelaHistoricoRush(quizzes);

                TableHistorico.Columns = new AntdUI.ColumnCollection
                {
                    new AntdUI.Column(nameof(QuizRushEntrada.Tipo), "Tipo"),
                    new AntdUI.Column(nameof(QuizRushEntrada.DataIniciado), "Data Iniciado"),
                    new AntdUI.Column(nameof(QuizRushEntrada.DataConcluido), "Data Concluído"),
                    new AntdUI.Column(nameof(QuizRushEntrada.Tempo), "Tempo"),
                    new AntdUI.Column(nameof(QuizRushEntrada.Streak), "Streak"),
                    new AntdUI.Column(nameof(QuizRushEntrada.PontuacaoTotal), "Pontuação Total")
                };


                TableHistorico.DataSource = null;
                TableHistorico.DataSource = quizzes;
            }
            catch
            {

            }
        }

        private void FiltrarData()
        {

        }

        private void MostrarMenuTodos(QuizResumo quiz)
        {
            if (quiz.TipoId == QuizTipo.Diario && quiz.DataConcluido == null)
            {
                _continuarItem.Enabled = true;
                _resultadoItem.Enabled = false;
            }

            if (quiz.TipoId == QuizTipo.Diario && quiz.DataConcluido != null)
            {
                _continuarItem.Enabled = false;
                _resultadoItem.Enabled = true;
            }

            if (quiz.TipoId == QuizTipo.Rush)
            {
                _continuarItem.Enabled = false;
            }

            AntdUI.ContextMenuStrip.open(
                this,
                item =>
                {
                    switch (item.Tag)
                    {
                        case "Continuar":
                            ContinuarQuiz?.Invoke(quiz.Id);
                            break;
                        case "Resultado":
                            VerResultado?.Invoke(quiz.Id);
                            break;
                        case "Copiar":
                            Clipboard.SetText(
                                $"Tipo: {quiz.Tipo}\nData Iniciado: {quiz.DataIniciado}\nFinalizado: {quiz.Concluido}\nData Finalizado: {quiz.DataConcluido}\nTempo: {quiz.Tempo}\nPontuação Total: {quiz.PontuacaoTotal}");
                            break;
                    }
                },
                _menuItems
            );
        }

        private void TableHistorico_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.Record is not QuizResumo quiz) return;

            MostrarMenuTodos(quiz);
        }

        private async void SelectQuizTipo_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not QuizTipo tipo) return;

            switch (tipo)
            {
                case QuizTipo.Todos:
                    await CarregarTabelaTodos();
                    break;
                case QuizTipo.Diario:
                    await CarregarTabelaDiario();
                    break;
                case QuizTipo.Rush:
                    await CarregarTabelaRush();
                    break;
            }
        }

        private async void SelectStatus_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not QuizStatus status) return;

            _statusAtual = status;
            if (_tipoAtual == QuizTipo.Diario) await CarregarTabelaDiario();
        }

        private async void ButtonBuscarData_Click(object sender, EventArgs e)
        {
            DateTime? minDate = DatePickerRangeQuiz.MinDate;
            DateTime? maxDate = DatePickerRangeQuiz.MaxDate;

            switch (_tipoAtual)
            {
                case QuizTipo.Todos:
                    await CarregarTabelaTodos(minDate, maxDate);
                    break;
                case QuizTipo.Diario:
                    await CarregarTabelaDiario(minDate, maxDate);
                    break;
                case QuizTipo.Rush:
                    await CarregarTabelaRush(minDate, maxDate);
                    break;
            }
        }
    }
}
