using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SenacQuizApp.Telas.Componentes.Quiz;

namespace SenacQuizApp.Telas
{
    public partial class PaginaQuiz : UserControl
    {
        private readonly QuizService _quizService;

        public event EventHandler? VoltarParaMenuPrincipal;

        public PaginaQuiz(QuizService quizService)
        {
            _quizService = quizService;
            InitializeComponent();
        }

        private async void PaginaQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
