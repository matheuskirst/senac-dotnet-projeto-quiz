using SenacQuizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas
{
    public partial class PaginaGerenciarQuestoes : UserControl
    {
        private readonly QuestaoService _questaoService;

        public PaginaGerenciarQuestoes(QuestaoService questaoService)
        {
            _questaoService = questaoService;

            InitializeComponent();
        }

        private void PaginaGerenciarQuestoes_Load(object sender, EventArgs e)
        {

        }
    }
}
