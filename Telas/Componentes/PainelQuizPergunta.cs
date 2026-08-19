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
        private readonly Pergunta _pergunta;
        public PainelQuizPergunta(Pergunta pergunta)
        {
            _pergunta = pergunta;

            InitializeComponent();
        }

        private void PainelQuizPergunta_Load(object sender, EventArgs e)
        {
            InputPergunta.Text = _pergunta.Enunciado;
        }
    }
}
