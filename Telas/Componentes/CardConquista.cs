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

            LabelAquisicao.Text = conquista.DataAquisicao.ToString("dd/MM/yyyy - HH\\:mm\\:ss");
        }
    }
}
