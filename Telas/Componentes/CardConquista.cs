using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Conquista;

namespace SenacQuizApp.Telas
{
    public partial class CardConquista : UserControl
    {
        public CardConquista(ConquistaDetalhes conquista)
        {
            InitializeComponent();

            LabelNome.Text = conquista.Nome;
            LabelDescricao.Text = conquista.Descricao;
            LabelPorcentagemJogadores.Text = $"{conquista.PorcentagemDesbloqueioGlobal}%";
            LabelAquisicao.Text = conquista.DataDesbloqueio?.ToString("dd/MM/yyyy - HH\\:mm\\:ss");

            if (conquista.Desbloqueada)
            {
                PanelIcone.BackColor = Color.Yellow;
            }
            else
            {
                LabelPorcentagemJogadores.Visible = false;
            }
        }
    }
}
