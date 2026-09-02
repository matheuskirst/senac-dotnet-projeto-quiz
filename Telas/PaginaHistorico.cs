using AntdUI;
using Microsoft.VisualBasic;
using SenacQuizApp.Dtos.Historico;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class PaginaHistorico : UserControl
    {
        private readonly HistoricoService _historicoService;
        public event Action<int>? ContinuarQuiz;
        public event Action<int, QuizTipo>? VerResultado;

        private AntdUI.ContextMenuStripItem _continuarItem;
        private AntdUI.ContextMenuStripItem _resultadoItem;
        private AntdUI.ContextMenuStripItem _copiarItem;
        private AntdUI.IContextMenuStripItem[] _menuItems;

        private QuizTipo _tipoAtual;
        private QuizStatus _statusAtual;

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
            _tipoAtual = QuizTipo.Todos;

            SelectStatus.Items.Add(new AntdUI.SelectItem("Todos", QuizStatus.Todos));
            SelectStatus.Items.Add(new AntdUI.SelectItem("Concluído", QuizStatus.Concluido));
            SelectStatus.Items.Add(new AntdUI.SelectItem("Não concluído", QuizStatus.NaoConcluido));

            SelectStatus.SelectedValue = QuizTipo.Todos;

            await CarregarHistorico();
        }

        private async Task CarregarHistorico()
        {
            try
            {
                TableHistorico.PauseLayout = true;
                TableHistorico.DataSource = null;

                LabelStatus.Visible = false;
                SelectStatus.Visible = false;


                DateTime? minDate = DatePickerRangeQuiz.MinDate;
                DateTime? maxDate = DatePickerRangeQuiz.MaxDate;

                var quizzes = await _historicoService.ObterTodos(_tipoAtual, minDate, maxDate, _statusAtual);

                switch (_tipoAtual)
                {
                    case QuizTipo.Diario:
                        LabelStatus.Visible = true;
                        SelectStatus.Visible = true;
                        TableHistorico.Columns = new AntdUI.ColumnCollection
                        {
                            new AntdUI.Column(nameof(QuizDiarioHistorico.Tipo), "Tipo"),
                            new AntdUI.Column(nameof(QuizDiarioHistorico.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                            new AntdUI.Column(nameof(QuizDiarioHistorico.ConcluidoDisplay), "Concluído"),
                            new AntdUI.Column(nameof(QuizDiarioHistorico.DataConcluido), "Data Concluído") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                            new AntdUI.Column(nameof(QuizDiarioHistorico.TempoDeConclusao), "Tempo para concluir") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                            new AntdUI.Column(nameof(QuizDiarioHistorico.TotalQuestoes), "Total Questões") { SortOrder = true },
                            new AntdUI.Column(nameof(QuizDiarioHistorico.TotalAcertos), "Acertos") { SortOrder = true },
                            new AntdUI.Column(nameof(QuizDiarioHistorico.PontuacaoTotal), "Pontuação Final") { SortOrder = true }
                        };
                        break;

                    case QuizTipo.Rush:
                        LabelStatus.Visible = false;
                        SelectStatus.Visible = false;
                        TableHistorico.Columns = new AntdUI.ColumnCollection
                        {
                            new AntdUI.Column(nameof(QuizRushEntrada.Tipo), "Tipo"),
                            new AntdUI.Column(nameof(QuizRushEntrada.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                            new AntdUI.Column(nameof(QuizRushEntrada.DataConcluido), "Data Concluído") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                            new AntdUI.Column(nameof(QuizRushEntrada.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                            new AntdUI.Column(nameof(QuizRushEntrada.Streak), "Streak") { SortOrder = true },
                            new AntdUI.Column(nameof(QuizRushEntrada.PontuacaoTotal), "Pontuação Total") { SortOrder = true }
                        };
                        break;

                    default:
                        LabelStatus.Visible = false;
                        SelectStatus.Visible = false;
                        TableHistorico.Columns = new AntdUI.ColumnCollection
                        {
                            new AntdUI.Column(nameof(QuizGenerico.Tipo), "Tipo") { SortOrder = true },
                            new AntdUI.Column(nameof(QuizGenerico.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                            new AntdUI.Column(nameof(QuizGenerico.ConcluidoDisplay), "Concluído ") { SortOrder = true },
                            new AntdUI.Column(nameof(QuizGenerico.DataConcluido), "Data Concluído ") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                            new AntdUI.Column(nameof(QuizGenerico.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                            new AntdUI.Column(nameof(QuizGenerico.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
                        };
                        break;

                }

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

        private void MostrarMenuTodos(QuizGenerico quiz)
        {
            if (quiz.Concluido == false)
            {
                _continuarItem.Enabled = true;
                _resultadoItem.Enabled = false;
            }

            if (quiz.Concluido == true)
            {
                _continuarItem.Enabled = false;
                _resultadoItem.Enabled = true;
            }

            if (quiz.TipoId == QuizTipo.Rush)
            {
                _continuarItem.Enabled = false;
                _resultadoItem.Enabled = true;
            }

            var contextMenu = new AntdUI.ContextMenuStrip.Config(
                this,
                item =>
                {
                    switch (item.Tag)
                    {
                        case "Continuar":
                            ContinuarQuiz?.Invoke(quiz.Id);
                            break;
                        case "Resultado":
                            VerResultado?.Invoke(quiz.Id, quiz.TipoId);
                            break;
                        case "Copiar":
                            Clipboard.SetText(
                                $"Tipo: {quiz.Tipo}\nData Iniciado: {quiz.DataIniciado}\nFinalizado: {quiz.Concluido}\nData Finalizado: {quiz.DataConcluido}\nTempo: {quiz.Tempo}\nPontuação Total: {quiz.PontuacaoTotal}");
                            break;
                    }
                },
                _menuItems)
            {
                ColorScheme = TAMode.Dark
            };

            contextMenu.open();
        }

        private void TableHistorico_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.Record is not QuizGenerico quiz) return;

            MostrarMenuTodos(quiz);
        }

        private async void SelectQuizTipo_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not QuizTipo tipo) return;

            _tipoAtual = tipo;
            await CarregarHistorico();
        }

        private async void SelectStatus_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not QuizStatus status) return;

            _statusAtual = status;
            await CarregarHistorico();
        }

        private async void ButtonBuscarData_Click(object sender, EventArgs e)
        {
            await CarregarHistorico();
        }
    }
}
