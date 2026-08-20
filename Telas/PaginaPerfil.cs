using SenacQuizApp.Dtos;
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
    public partial class PaginaPerfil : UserControl
    {
        private readonly AutenticacaoService _usuarioService;


        public PaginaPerfil(AutenticacaoService usuarioService)
        {
            _usuarioService = usuarioService;

            InitializeComponent();
        }

        private void PaginaPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
