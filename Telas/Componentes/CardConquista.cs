using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Conquista;
using SenacQuizApp.Utils;

namespace SenacQuizApp.Telas
{
    public partial class CardConquista : UserControl
    {
        public CardConquista(ConquistaDetalhes conquista, bool mostrarData = false, bool mostrarPorcentagemGlobal = false)
        {
            InitializeComponent();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (conquista.IconPath != null)
            {
                string fullPath = Path.Combine(baseDirectory, conquista.IconPath);

                if (File.Exists(fullPath))
                {
                    using (var fs = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        avatar1.Image = Image.FromStream(fs);
                    }

                    if (conquista.Desbloqueada == false)
                    {
                         avatar1.Image = ImageMatrix.MakeImageGray(avatar1.Image);
                    }
                }
            }

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
