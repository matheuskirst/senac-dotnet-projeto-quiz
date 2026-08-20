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
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas
{
    public partial class PaginaRanking : UserControl
    {
        private readonly AutenticacaoService _usuarioService;

        public event EventHandler? VoltarParaMenu;

        public PaginaRanking(AutenticacaoService usuarioService)
        {
            _usuarioService = usuarioService;

            InitializeComponent();
        }
    }
}
