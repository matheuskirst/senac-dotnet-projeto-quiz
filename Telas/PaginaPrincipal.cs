using System.ComponentModel;
using AntdUI;
using SenacQuizApp.Services;
using SenacQuizApp.Enums;
using SenacQuizApp.Dtos;
using SenacQuizApp.Telas.Componentes;
using System.Runtime.InteropServices.Marshalling;

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

        public PaginaPrincipal(HistoricoService historicoService)
        {
            _historicoService = historicoService;

            InitializeComponent();
        }

        private async void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            await AtualizarTabelaResumos();
        }

        private async Task AtualizarTabelaResumos()
        {
            CarregarColunasTabelaResumo();
            try
            {
                List<QuizResumo> quizzes = await _historicoService.ObterResumoRecentes();
                if (quizzes == null) return;

                try
                {
                    TableResumo.PauseLayout = true;
                    TableResumo.DataSource = null;
                    TableResumo.DataSource = quizzes;
                }
                finally
                {
                    TableResumo.PauseLayout = false;
                }
            }
            catch
            {

            }
        }

        private void CarregarColunasTabelaResumo()
        {
            TableResumo.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuizResumo.Tipo), "Tipo") { SortOrder = true },
                new AntdUI.Column(nameof(QuizResumo.DataIniciado), "Data Iniciado") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                new AntdUI.Column(nameof(QuizResumo.FinalizadoDisplay), "Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(QuizResumo.DataFinalizado), "Data Finalizado ") { SortOrder = true, DisplayFormat = @"dd/MM/yyyy - HH\:mm\:ss" },
                new AntdUI.Column(nameof(QuizResumo.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff" },
                new AntdUI.Column(nameof(QuizResumo.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
            };
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

            if (quiz.TipoId == QuizTipo.Diario && quiz.Finalizado == true)
            {
                continuarItem.Enabled = false;
                resultadoItem.Enabled = true;
            }

            if (quiz.TipoId == QuizTipo.Diario && quiz.Finalizado == false)
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

        private void TableResumo_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.Record is not QuizResumo quiz) return;

            MostrarMenuQuizzes(quiz);
        }
    }
}
