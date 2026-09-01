using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.QuizDiario;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class CardQuestao : UserControl
    {
        public CardQuestao(string questaoIndex, QuestaoResultado questao)
        {
            InitializeComponent();

            // Habilita o buffer duplo e força o redesenho completo ao mover/rolar
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw, true);

            // Opcional: Garante que o suporte a fundos transparentes do WinForms não quebre a rolagem
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);

            this.UpdateStyles();

            LabelIndex.Text = questaoIndex;
            LabelEnunciado.Text = questao.Enunciado;
        }
    }
}
