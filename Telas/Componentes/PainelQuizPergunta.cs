using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class PainelQuizPergunta : UserControl
    {
        public event Action<int>? ClicouAlternativa;
        private readonly PerguntasEncontradas? _pergunta;
        private readonly List<AlternativaDto>? _alternativas;
        public PainelQuizPergunta(PerguntasEncontradas pergunta, List<AlternativaDto> alternativas)
        {
            _pergunta = pergunta;
            _alternativas = alternativas;

            InitializeComponent();
        }

        private void PainelQuizPergunta_Load(object sender, EventArgs e)
        {
            if (_pergunta != null)
            {
                InputPergunta.Text = _pergunta.Enunciado;
            }
            if (_alternativas != null)
            {
                PanelRespostas.Controls.Clear();

                foreach (AlternativaDto alternativa in _alternativas)
                {
                    AntdUI.Button button = new AntdUI.Button();
                    button.Tag = alternativa.Id;
                    button.Text = alternativa.Texto;
                    button.Click += AoClicarAlternativa;

                    PanelRespostas.Controls.Add(button);
                }
            }
        }

        private void AoClicarAlternativa(object? sender, EventArgs e)
        {
            if (sender is AntdUI.Button button && button.Tag is int Id)
            {
                ClicouAlternativa?.Invoke(Id);
            }
        }
    }
}
