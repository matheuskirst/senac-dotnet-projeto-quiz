using System.ComponentModel;
using AntdUI;
using SenacQuizApp.Services;
using SenacQuizApp.Enums;
using SenacQuizApp.Dtos;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly HistoricoService _historicoService;

        public event EventHandler? RealizarLogout;

        public event EventHandler? AbrirHubQuizDiario;
        public event EventHandler? AbrirHubQuizRush;

        public event Action<int>? ContinuarQuizDiario;
        public event Action<int>? ResultadoQuizDiario;
        public event Action<int>? AbrirQuizRush;

        private TabelaHistoricoTodos _tabelaHistorico = new();

        public PaginaPrincipal(HistoricoService historicoService)
        {
            _historicoService = historicoService;

            ConfigurarTabelaPreview();

            InitializeComponent();

            PanelResumoQuizzes.Controls.Add(_tabelaHistorico);
            _tabelaHistorico.BringToFront();
        }

        private async void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            await AtualizarPreviewResumos();
        }

        private void ConfigurarTabelaPreview()
        {
            _tabelaHistorico.Dock = DockStyle.Fill;
            _tabelaHistorico.ColorScheme = TAMode.Dark;
            _tabelaHistorico.AutoSizeColumnsMode = ColumnsMode.Fill;
            _tabelaHistorico.ColumnDragSort = true;
            _tabelaHistorico.EnableHeaderResizing = true;

            _tabelaHistorico.CellClick += (sender, e) =>
            {
                if (e.Button != MouseButtons.Right || e.Record is not QuizResumo quiz) return;

                MostrarMenuQuizzes(quiz);
            };
        }

        private async Task AtualizarPreviewResumos()
        {
            try
            {
                List<QuizResumo> quizzes = await _historicoService.ObterResumoRecentes();
                if (quizzes == null) return;

                try
                {
                    _tabelaHistorico.PauseLayout = true;
                    _tabelaHistorico.DataSource = null;
                    _tabelaHistorico.DataSource = quizzes;
                }
                finally
                {
                    _tabelaHistorico.PauseLayout = false;
                }
            }
            catch
            {

            }
        }

        private void ButtonPrincipalSair_Click(object sender, EventArgs e)
        {
            RealizarLogout?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonQuizDiario_Click(object sender, EventArgs e)
        {
            AbrirHubQuizDiario?.Invoke(this, EventArgs.Empty);
        }

        private void MostrarMenuQuizzes(QuizResumo quiz)
        {
            var continuarItem = new AntdUI.ContextMenuStripItem("Continuar") { Tag = "Continuar" };
            var resultadoItem = new AntdUI.ContextMenuStripItem("Ver Resultado") { Tag = "Resultado" };
            var copiarItem = new AntdUI.ContextMenuStripItem("Copiar dados") { Tag = "Copiar" };

            if (quiz.TipoId == QuizTipo.Diario && quiz.DataFinalizado != null)
            {
                continuarItem.Enabled = false;
                resultadoItem.Enabled = true;
            }

            if (quiz.TipoId == QuizTipo.Diario && quiz.DataFinalizado == null)
            {
                continuarItem.Enabled = true;
                resultadoItem.Enabled = false;
            }

            if (quiz.TipoId == QuizTipo.Rush)
            {
                continuarItem.Enabled = false;
                resultadoItem.Enabled = true;
            }

            var menuItems = new AntdUI.IContextMenuStripItem[]
            {
                continuarItem,
                resultadoItem,
                new AntdUI.ContextMenuStripItemDivider(),
                copiarItem
            };

            var menuStrip = new AntdUI.ContextMenuStrip.Config(this, item =>
            {
                switch (item.Tag)
                {
                    case "Continuar":
                        ContinuarQuizDiario?.Invoke(quiz.Id);
                        break;
                    case "Resultado":
                        ResultadoQuizDiario?.Invoke(quiz.Id);
                        break;
                    case "Copiar":
                        Clipboard.SetText(
                            $"Tipo: {quiz.Tipo}\nData Iniciado: {quiz.DataIniciado}\nFinalizado: {quiz.Finalizado}\nData Finalizado: {quiz.DataFinalizado}\nTempo: {quiz.Tempo}\nPontuação Total: {quiz.PontuacaoTotal}");
                        break;
                }
            },
            menuItems
            )
            {
                ColorScheme = TAMode.Dark
            };

            menuStrip.open();
        }
    }
}
