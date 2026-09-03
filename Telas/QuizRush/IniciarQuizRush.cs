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

namespace SenacQuizApp.Telas.QuizRush
{
    public partial class IniciarQuizRush : UserControl
    {
        private readonly QuizRushService _quizRushService;

        public event EventHandler? IniciarRush;

        public IniciarQuizRush(QuizRushService quizRushService)
        {
            _quizRushService = quizRushService;

            InitializeComponent();
        }

        private async void IniciarQuizRush_Load(object sender, EventArgs e)
        {
            var ultimoRecorde = await _quizRushService.ObterUltimoRecorde();

            if (ultimoRecorde == null) return;

            LabelDataPartida.Text = ultimoRecorde.DataRecorde.ToString(@"dd/MM/yyyy HH\:mm\:ss");
            LabelRecordeAcertos.Text = ultimoRecorde.Streak.ToString();
            LabelTempo.Text = ultimoRecorde.Tempo.ToString(@"hh\:mm\:ss\.fff");
        }

        private void ButtonQuizRush_Click(object sender, EventArgs e)
        {
            IniciarRush?.Invoke(sender, EventArgs.Empty);
        }
    }
}
