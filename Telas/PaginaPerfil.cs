using SenacQuizApp.Modelos;
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
        private readonly int _usuarioId;
        private readonly UsuarioPerfilService _usuarioPerfilService;

        public event Action<int>? AbrirConquistas;

        public PaginaPerfil(int usuarioId, UsuarioPerfilService usuarioPerfilService)
        {
            _usuarioId = usuarioId;
            _usuarioPerfilService = usuarioPerfilService;

            InitializeComponent();
        }

        private void PaginaPerfil_Load(object sender, EventArgs e)
        {

        }

        private void ButtonConquistas_Click(object sender, EventArgs e)
        {

        }
    }
}
