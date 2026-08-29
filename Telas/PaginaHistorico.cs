using AntdUI;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizRush;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;
using System.Linq;

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

            InitializeComponent();

            _continuarItem = new AntdUI.ContextMenuStripItem()
            {
                Text = "Continuar",
                Tag = "Continuar"
            };
            _resultadoItem = new AntdUI.ContextMenuStripItem("Ver Resultado")
            {
                Text = "Ver Resultado",
                Tag = "Resultado"
            };
            _copiarItem = new AntdUI.ContextMenuStripItem("Copiar dados")
            {
                Text = "Copiar dados",
                Tag = "Copiar"
            };

            _menuItems = new AntdUI.IContextMenuStripItem[]
            {
                _continuarItem,
                _resultadoItem,
                new AntdUI.ContextMenuStripItemDivider(),
                _copiarItem
            };
        }

        private async void PaginaHistorico_Load(object sender, EventArgs e)
        {
            await CarregarTabelaTodos();
        }

        private void InserirTabela(AntdUI.Table tabela)
        {
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
                List<ResumoQuiz> quizzes = await _historicoService.ObterTodos();

                if (quizzes == null) return;

                var tabela = new TabelaHistoricoTodos(quizzes);
                tabela.CellClick += (sender, e) =>
                {
                    if (e.Button != MouseButtons.Right || e.Record is not ResumoQuiz quiz) return;

                    MostrarMenuTodos(quiz);
                };

                InserirTabela(tabela);
            }
            catch
            {

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

        private void MostrarMenuTodos(ResumoQuiz quiz)
        {
            if (quiz.TipoId == QuizTipoId.Diario && quiz.DataFinalizado == null)
            {
                _continuarItem.Enabled = true;
                _resultadoItem.Enabled = false;
            }

            if (quiz.TipoId == QuizTipoId.Diario && quiz.DataFinalizado != null)
            {
                _continuarItem.Enabled = false;
                _resultadoItem.Enabled = true;
            }

            if (quiz.TipoId == QuizTipoId.Rush)
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
    }
}
