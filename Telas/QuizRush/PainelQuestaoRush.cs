using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Telas.QuizRush
{
    public partial class PainelQuestaoRush : UserControl
    {
        private QuestaoExibicao? _questao;
        public event Action<int>? EscolheuAlternativa;
        public event Action<bool>? EscolheuVerdadeiroFalso;

        public PainelQuestaoRush()
        {
            InitializeComponent();
        }

        public void CarregarQuestao(QuestaoExibicao questao)
        {
            _questao = questao;
            this.SuspendLayout();
            try
            {
                InputQuestaoEnunciado.Clear();

                while (GridPanelAlternativas.Controls.Count > 0)
                {
                    var controle = GridPanelAlternativas.Controls[0];
                    controle.Dispose();
                }

                InputQuestaoEnunciado.Text = _questao.Enunciado;

                if (_questao.Tipo == QuestaoTipo.Alternativas)
                {
                    GridPanelAlternativas.Height = 300;
                    GridPanelAlternativas.Span = "50% 50%; 50% 50%";

                    foreach (AlternativaExibicao alternativa in _questao.Alternativas)
                    {
                        var button = new AntdUI.Button
                        {
                            Tag = alternativa.Id,
                            Text = alternativa.Texto,
                            TextMultiLine = true,
                            ColorScheme = AntdUI.TAMode.Dark,
                            BorderWidth = 1,
                            Font = new Font("Segoe UI", 16),
                            Dock = DockStyle.Fill
                        };

                        button.Click += AlternativaEscolhida;

                        GridPanelAlternativas.Controls.Add(button);
                    }
                }
                else
                {
                    GridPanelAlternativas.Height = 150;
                    GridPanelAlternativas.Span = "50% 50%";
                    var buttonFalso = new AntdUI.Button
                    {
                        Tag = false,
                        Text = "Falso",
                        ColorScheme = AntdUI.TAMode.Dark,
                        BorderWidth = 1,
                        Font = new Font("Segoe UI", 16),
                        Dock = DockStyle.Fill
                    };
                    buttonFalso.Click += AlternativaEscolhida;
                    GridPanelAlternativas.Controls.Add(buttonFalso);

                    var buttonVerdade = new AntdUI.Button
                    {
                        Tag = true,
                        Text = "Verdadeiro",
                        ColorScheme = AntdUI.TAMode.Dark,
                        BorderWidth = 1,
                        Font = new Font("Segoe UI", 16),
                        Dock = DockStyle.Fill
                    };
                    buttonVerdade.Click += AlternativaEscolhida;
                    GridPanelAlternativas.Controls.Add(buttonVerdade);
                }
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        private void AlternativaEscolhida(object? sender, EventArgs e)
        {
            if (sender is not AntdUI.Button botaoClicado || botaoClicado.Tag is null) return;

            if (_questao?.Tipo == QuestaoTipo.Alternativas && botaoClicado.Tag is int alternativaId)
            {
                EscolheuAlternativa?.Invoke(alternativaId);
            }
            else if (_questao?.Tipo == QuestaoTipo.VerdadeiroOuFalso && botaoClicado.Tag is bool opcao)
            {
                EscolheuVerdadeiroFalso?.Invoke(opcao);
            }
        }
    }
}
