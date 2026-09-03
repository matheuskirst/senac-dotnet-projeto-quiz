using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Conquista;

namespace SenacQuizApp.Telas
{
    public partial class CardConquista : UserControl
    {
        public CardConquista(ConquistaDetalhes conquista, bool mostrarData = false, bool mostrarPorcentagemGlobal = false)
        {
            InitializeComponent();
            LabelData.Visible = false;
            LabelPorcentagemGlobal.Visible = false;

            LabelNome.Text = conquista.Nome;
            LabelDescricao.Text = conquista.Descricao;

            if (conquista.Desbloqueada && mostrarData)
            {
                LabelData.Visible = true;
                LabelData.Text = conquista.DataDesbloqueio?.ToString("dd/MM/yyyy - HH\\:mm\\:ss");

                PanelIcone.BackColor = Color.Yellow;
            }

            if (mostrarPorcentagemGlobal)
            {
                LabelPorcentagemGlobal.Text = $"{conquista.PorcentagemDesbloqueioGlobal}%";
                LabelPorcentagemGlobal.Visible = true;
            }
        }
    }
}
