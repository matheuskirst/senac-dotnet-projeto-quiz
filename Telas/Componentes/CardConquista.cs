using SenacQuizApp.Dtos;

namespace SenacQuizApp.Telas
{
    public partial class CardConquista : UserControl
    {
        public CardConquista(ConquistaDto conquista)
        {
            InitializeComponent();

            LabelNome.Text = conquista.Nome;
            LabelDescricao.Text = conquista.Descricao;
        }
    }
}
