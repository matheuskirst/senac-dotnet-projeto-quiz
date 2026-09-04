using SenacQuizApp.Enums;
using SenacQuizApp.Dtos;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class CardQuestaoRespondida : UserControl
    {
        public CardQuestaoRespondida(string questaoIndex, QuestaoRespondida questao)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            try
            {
                PanelAlternativas.SuspendLayout();

                LabelIndex.Text = questaoIndex;
                LabelEnunciado.Text = questao.Enunciado;

                if (questao.Acertou)
                {
                    BackColor = Color.FromArgb(64, 74, 64);
                }
                else
                {
                    BackColor = Color.FromArgb(74, 64, 64);
                }

                if (questao.Tipo == QuestaoTipo.Alternativas && questao.Alternativas != null)
                {
                    LabelUsuarioResposta.Text = questao.AlternativaEscolhida != null ? questao.AlternativaEscolhida : "---";

                    int alternativaNumero = 1;
                    foreach (AlternativaResposta alternativa in questao.Alternativas)
                    {
                        var label = new AntdUI.Label
                        {
                            Text = $"{alternativaNumero}. {alternativa.Texto}",
                            ColorScheme = AntdUI.TAMode.Dark
                        };

                        if (alternativa.Correta)
                        {
                            LabelRespostaCorreta.Text = alternativa.Texto;
                        }

                        label.AutoSize = true;

                        PanelAlternativas.Controls.Add(label);
                        alternativaNumero++;
                    }
                }

                else if (questao.Tipo == QuestaoTipo.VerdadeiroOuFalso)
                {
                    LabelRespostaCorreta.Text = questao.VerdadeiroFalso == true ? "Verdadeiro" : "Falso";
                    LabelUsuarioResposta.Text = questao.VerdadeiroFalsoEscolhido == true ? "Verdadeiro" : "Falso";

                    var labelV = new AntdUI.Label
                    {
                        Text = "1. Verdadeiro",
                        ColorScheme = AntdUI.TAMode.Dark
                    };

                    var labelF = new AntdUI.Label
                    {
                        Text = "2. Falso",
                        ColorScheme = AntdUI.TAMode.Dark
                    };

                    labelV.AutoSize = true;
                    PanelAlternativas.Controls.Add(labelV);
                    labelF.AutoSize = true;
                    PanelAlternativas.Controls.Add(labelF);
                }
            }
            finally
            {
                PanelAlternativas.ResumeLayout();
            }
        }

        private void LabelIndex_Click(object sender, EventArgs e)
        {

        }
    }
}
