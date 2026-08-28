using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes.Quiz;
using SenacQuizApp.Dtos.QuizDiario.Andamento;
using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos;
using System.ComponentModel;
using SenacQuizApp.Telas.Componentes;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPrincipal : UserControl
    {
        private readonly QuizDiarioService _quizService;
        private readonly HistoricoService _historicoService;

        public event EventHandler? RealizarLogout;

        public event EventHandler? AbrirHubQuizDiario;
        public event EventHandler? AbrirHubQuizRush;

        public event Action<int>? ContinuarQuizDiario;
        public event Action<int>? ResultadoQuizDiario;

        public event Action<int>? AbrirQuizRush;

        private readonly BindingList<ResumoQuiz> _quizList = [];

        public PaginaPrincipal(QuizDiarioService quizService, HistoricoService historicoService)
        {
            _quizService = quizService;
            _historicoService = historicoService;

            InitializeComponent();
        }

        private async void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            TableQuizHistorico.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(ResumoQuiz.Tipo), "Tipo") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.DataIniciado), "Data Iniciado") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.Finalizado), "Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.DataFinalizado), "Data Finalizado ") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.Tempo), "Tempo") { SortOrder = true },
                new AntdUI.Column(nameof(ResumoQuiz.PontuacaoTotal), "Pontuação Total  ") { SortOrder = true },
            };

            TableQuizHistorico.DataSource = _quizList;

            await AtualizarPreviewResumos();
        }

        private async Task AtualizarPreviewResumos()
        {
            List<ResumoQuiz> quizzes = await _historicoService.ObterResumoRecentes();
            if (quizzes == null) return;

            TableQuizHistorico.PauseLayout = true;
            try
            {
                _quizList.Clear();

                foreach (ResumoQuiz quiz in quizzes)
                {
                    _quizList.Add(quiz);
                }
            }
            finally
            {
                TableQuizHistorico.PauseLayout = false;
                TableQuizHistorico.Refresh();
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

        private void MostrarMenuQuizDiario(ResumoQuiz quiz)
        {
            var continuarItem = new AntdUI.ContextMenuStripItem()
            {
                Text = "Continuar",
                Tag = "Continuar"
            };
            var resultadoItem = new AntdUI.ContextMenuStripItem("Ver Resultado")
            {
                Text = "Ver Resultado",
                Tag = "Resultado"
            };
            var copiarItem = new AntdUI.ContextMenuStripItem("Copiar dados")
            {
                Text = "Copiar dados",
                Tag = "Copiar"
            };

            if (quiz.DataFinalizado != null)
            {
                continuarItem.Enabled = false;
                resultadoItem.Enabled = true;
            }

            if (quiz.DataFinalizado == null)
            {
                continuarItem.Enabled = true;
                resultadoItem.Enabled = false;
            }

            var menuItems = new AntdUI.IContextMenuStripItem[]
            {
                continuarItem,
                resultadoItem,
                new AntdUI.ContextMenuStripItemDivider(),
                copiarItem
            };

            AntdUI.ContextMenuStrip.open(
                TableQuizHistorico,
                item =>
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
            );
        }

        private void TableQuizHistorico_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.Record is not ResumoQuiz quiz) return;

            MostrarMenuQuizDiario(quiz);
        }
    }
}
