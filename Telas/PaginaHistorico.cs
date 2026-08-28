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
    public partial class PaginaHistorico : UserControl
    {
        private readonly HistoricoService _historicoService;
        public PaginaHistorico(HistoricoService historicoService)
        {
            _historicoService = historicoService;

            InitializeComponent();
        }

        private void PaginaHistorico_Load(object sender, EventArgs e)
        {

        }
    }
}
