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

namespace SenacQuizApp.Features.Login
{
    public partial class PaginaLogin : UserControl
    {
        private readonly UsuarioService _usuarioService;

        public PaginaLogin(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;

            InitializeComponent();
        }
    }
}
