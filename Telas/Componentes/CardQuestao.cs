using SenacQuizApp.Enums;
using SenacQuizApp.Dtos.QuizDiario;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class CardQuestao : UserControl
    {
        public CardQuestao(string questaoIndex, QuestaoResultado questao)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            LabelIndex.Text = questaoIndex;
            LabelEnunciado.Text = questao.Enunciado;

            if (questao.Acertou)
            {
                LabelAcertou.Text = "Sim";
            }
            else
            {
                LabelAcertou.Text = "Não";
            }

            if (questao.Tipo == QuestaoTipo.Alternativas && questao.Alternativas != null)
            {
                foreach(AlternativaCorreta alternativa in questao.Alternativas)
                {
                    var label = new AntdUI.Label
                    {
                        Text = alternativa.Texto,
                        ColorScheme = AntdUI.TAMode.Dark
                    };

                    if (alternativa.Correta)
                    {
                        label.ForeColor = Color.LimeGreen;
                    }
                    else
                    {
                        label.ForeColor = Color.Red;
                    }

                    label.AutoSize = true;
                    StackPanelAlternativas.Controls.Add(label);
                }
            }
            else if (questao.Tipo == QuestaoTipo.VerdadeiroOuFalso)
            {
                var labelV = new AntdUI.Label
                {
                    Text = "Verdadeiro",
                    ColorScheme = AntdUI.TAMode.Dark
                };

                var labelF = new AntdUI.Label
                {
                    Text = "Falso",
                    ColorScheme = AntdUI.TAMode.Dark
                };

                if (questao.VerdadeiroFalso == true)
                {
                    labelV.ForeColor = Color.LimeGreen;
                    labelF.ForeColor = Color.Red;
                }
                else
                {
                    labelV.ForeColor = Color.Red;
                    labelF.ForeColor = Color.LimeGreen;
                }

                labelF.AutoSize = true;
                StackPanelAlternativas.Controls.Add(labelF);
                labelV.AutoSize = true;
                StackPanelAlternativas.Controls.Add(labelV);
            }
        }
    }
}
