using AntdUI;
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
            await CarregarTabelaTodos();
        }

        private void InserirTabela(AntdUI.Table tabela)
        {
            DatePickerRangeQuiz.Clear();
            CheckboxQuizFinalizado.Checked = false;

            PanelInserirHistorico.SuspendLayout();
            try
            {
                while (PanelInserirHistorico.Controls.Count > 0)
                {
                    var controle = PanelInserirHistorico.Controls[0];
                    controle.Dispose();
                }

                tabela.Dock = DockStyle.Fill;
                tabela.ColorScheme = TAMode.Dark;
                tabela.AutoSizeColumnsMode = ColumnsMode.Fill;
                PanelInserirHistorico.Controls.Add(tabela);
            }
            finally
            {
                PanelInserirHistorico.ResumeLayout();
            }
        }

        private async Task CarregarTabelaTodos()
        {
            try
            {
                TableHistorico.PauseLayout = true;

                List<QuizResumo> quizzes = await _historicoService.ObterTodos();
                if (quizzes == null) return;

                TableHistorico.Columns = new AntdUI.ColumnCollection
                {
                    new AntdUI.Column(nameof(QuizResumo.Tipo), "Tipo") { SortOrder = true },
                    new AntdUI.Column(nameof(QuizResumo.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                    new AntdUI.Column(nameof(QuizResumo.FinalizadoDisplay), "Finalizado ") { SortOrder = true },
                    new AntdUI.Column(nameof(QuizResumo.DataFinalizado), "Data Finalizado ") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
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
        private async Task CarregarTabelaDiario()
        {
            try
            {
                List<QuizDiarioHistorico> quizzes = await _historicoService.ObterHistoricosDiario();

                if (quizzes == null) return;

                var tabela = new TabelaHistoricoDiario(quizzes);

                InserirTabela(tabela);
            }
            catch
            {

            }
        }

        private async Task CarregarTabelaRush()
        {
            try
            {
                List<QuizRushEntrada> quizzes = await _historicoService.ObterEntradasRush();

                if (quizzes == null) return;

                var tabela = new TabelaHistoricoRush(quizzes);

                InserirTabela(tabela);
            }
            catch
            {

            }
        }

        private void MostrarMenuTodos(QuizResumo quiz)
        {
            if (quiz.TipoId == QuizTipo.Diario && quiz.DataFinalizado == null)
            {
                _continuarItem.Enabled = true;
                _resultadoItem.Enabled = false;
            }

            if (quiz.TipoId == QuizTipo.Diario && quiz.DataFinalizado != null)
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
                                $"Tipo: {quiz.Tipo}\nData Iniciado: {quiz.DataIniciado}\nFinalizado: {quiz.Finalizado}\nData Finalizado: {quiz.DataFinalizado}\nTempo: {quiz.Tempo}\nPontuação Total: {quiz.PontuacaoTotal}");
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
    }
}
