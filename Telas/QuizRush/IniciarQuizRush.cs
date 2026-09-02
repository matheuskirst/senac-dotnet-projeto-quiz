using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas.QuizRush
{
    public partial class IniciarQuizRush : UserControl
    {
        public event EventHandler? IniciarRush;

        public IniciarQuizRush()
        {
            InitializeComponent();
        }

        private void ButtonQuizRush_Click(object sender, EventArgs e)
        {
            IniciarRush?.Invoke(sender, EventArgs.Empty);
        }
    }
}
