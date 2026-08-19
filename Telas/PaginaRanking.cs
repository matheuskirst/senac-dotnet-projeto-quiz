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
        private readonly UsuarioService _usuarioService;
        private readonly PerguntaService _perguntaService;

        public event EventHandler? VoltarParaMenu;

        public PaginaRanking(UsuarioService usuarioService, PerguntaService perguntaService)
        {
            _usuarioService = usuarioService;
            _perguntaService = perguntaService;

            InitializeComponent();
        }
    }
}
