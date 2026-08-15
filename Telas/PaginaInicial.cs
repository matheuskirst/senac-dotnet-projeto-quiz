using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Features.PaginaInicial
{
    public partial class PaginaInicial : UserControl
    {
        public event EventHandler? EscolheuLogin;
        public event EventHandler? EscolheuSignup;

        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void ButtonInicialLogin_Click(object sender, EventArgs e)
        {
            EscolheuLogin?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonInicialSignup_Click(object sender, EventArgs e)
        {
            EscolheuSignup?.Invoke(this, EventArgs.Empty);
        }
    }
}
