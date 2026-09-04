using Microsoft.EntityFrameworkCore.Update;
using SenacQuizApp.Dtos;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;
using System.ComponentModel;

namespace SenacQuizApp.Telas.QuizDiario
{
    public partial class ResultadoQuizDiario : UserControl
    {
        private int _quizId;
        private readonly QuizDiarioService _quizDiarioService;
        private readonly ContainerControl? _parente;

        public ResultadoQuizDiario(int quizId, QuizDiarioService quizDiarioService, ContainerControl? parente=null)
        {
            _quizId = quizId;
            _quizDiarioService = quizDiarioService;
            _parente = parente;

            InitializeComponent();
        }

        private async void PainelResultado_Load(object sender, EventArgs e)
        {
            try
            {
                PanelQuestoes.SuspendLayout();

                QuizDiarioCompleto? resultado = await _quizDiarioService.ObterResultadoPorId(_quizId);

                if (resultado == null) return;

                LabelDataInicio.Text = resultado.DataIniciado.ToString(@"dd/MM/yyyy HH\:mm\:ss");
                LabelDataConcluido.Text = resultado.DataConcluido?.ToString(@"dd/MM/yyyy HH\:mm\:ss") ?? "Não disponível";
                LabelTempoDeConclusao.Text = resultado.TempoDeConclusao?.ToString(@"hh\:mm\:ss\.fff") ?? "Não disponível";
                LabelTotalQuestoes.Text = resultado.TotalQuestoes.ToString();
                LabelTotalAcertos.Text = resultado.TotalAcertos.ToString();
                LabelPontuacaoTotal.Text = resultado.PontuacaoTotal.ToString();

                int questaoNumero = 1;
                foreach (var questao in resultado.Questoes)
                {
                    string questaoEnunciado = questao.Enunciado;

                    var cardQuestao = new CardQuestao(questaoNumero.ToString(), questao);
                    cardQuestao.Dock = DockStyle.Top;
                    PanelQuestoes.Controls.Add(cardQuestao);
                    questaoNumero++;
                }
            }
            catch
            {
                if (_parente is not FormApp formApp) return;

                AntdUI.Modal.open(new AntdUI.Modal.Config(formApp, "Erro de Conexão", "Ocorreu um erro ao se conectar com o servidor.")
                {
                    ColorScheme = AntdUI.TAMode.Dark,
                    OkText = "Ok",
                    Icon = AntdUI.TType.Error,
                    CancelText = null
                });
                return;
            }
            finally
            {
                PanelQuestoes.ResumeLayout();
            }
        }
    }
}
