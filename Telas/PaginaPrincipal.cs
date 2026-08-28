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

        public event Action<int>? AbrirQuizDiario;
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
                new AntdUI.Column(nameof(ResumoQuiz.Tipo), "Tipo"),
                new AntdUI.Column(nameof(ResumoQuiz.DataIniciado), "Data Iniciado"),
                new AntdUI.Column(nameof(ResumoQuiz.Finalizado), "Finalizado"),
                new AntdUI.Column(nameof(ResumoQuiz.DataFinalizado), "Data Finalizado"),
                new AntdUI.Column(nameof(ResumoQuiz.Tempo), "Tempo"),
                new AntdUI.Column(nameof(ResumoQuiz.PontuacaoTotal), "Pontuação Total")
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
            var menuItems = new AntdUI.IContextMenuStripItem[]
            {
                new AntdUI.ContextMenuStripItem("Abrir perfil"),
                new AntdUI.ContextMenuStripItemDivider(),
                new AntdUI.ContextMenuStripItem("Copiar nickname")
            };

            AntdUI.ContextMenuStrip.open(
                TableQuizHistorico,
                item =>
                {
                    switch (item.Text)
                    {
                        case "Continuar":
                            AbrirQuizDiario?.Invoke(quiz.Id);
                            break;                        
                        case "Ver Resultado":
                            AbrirQuizDiario?.Invoke(quiz.Id);
                            break;
                        case "Copiar dados":
                            Clipboard.SetText(
                                $@"Tipo: {quiz.Tipo}
                                   Data Iniciado: {quiz.DataIniciado}         
                                   Finalizado: {quiz.Finalizado}         
                                   Data Finalizado: {quiz.DataFinalizado}
                                   Tempo: {quiz.Tempo}
                                   Pontuação Total: {quiz.PontuacaoTotal}
                                ");
                            break;
                    }
                },
                menuItems
            );
        }
    }
}
